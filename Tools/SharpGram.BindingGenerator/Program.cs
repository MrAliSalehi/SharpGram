using System.Text;
using Humanizer;
using SharpGram.BindingGenerator;
using SharpGram.BindingGenerator.Models;

var baseApiPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.Parent!.FullName, "SharpGram.BindingGenerator", "Tl");
const string warnings = "// ReSharper disable IdentifierTypo PartialTypeWithSinglePart InconsistentNaming CheckNamespace MemberCanBePrivate.Global ClassNeverInstantiated.Global PropertyCanBeMadeInitOnly.Global UnusedAutoPropertyAccessor.Global CollectionNeverUpdated.Global";
var schema = Schema.ApiSchema;

TextParser.FixSchema(schema);
//todo 2 flags at the same time, flags1 flags2

var groups = TypeParser.Group(schema);



Dictionary<string, List<Param>> commonParams = [];

await GenerateTypes();

await GenerateConstructors();
//await GenerateMtProto(); DO NOT uncomment this
await GenerateFunctions();

return;

async Task GenerateFunctions()
{
    var funcPath = Path.Combine(baseApiPath, "Functions.cs");

    var strFunc = new StringBuilder($"using SharpGram.Core.Models.Types;using SharpGram.Tl.Types;using SharpGram.Core.Conversions;using SharpGram.Core.Contracts;" +
                                    $"using Tel = SharpGram.Tl.Constructors;" +
                                    $"\n{warnings}\n\nnamespace SharpGram.Tl.Functions {{\n");

    foreach (var x in schema.Methods.Where(p => p.Name.StartsWith("Invoke")))
        x.NameSpace = "Invoke";

    var methodGroups = schema.Methods.GroupBy(p => p.NameSpace).OrderBy(p => p.Key).ThenBy(p => p.Count()).ToList();

    foreach (var methodGroup in methodGroups)
    {
        if (methodGroup.Key is "Invoke" or "InitConnection") continue; //TODO ignore the invoke and init for now
        var methods = methodGroup.OrderByDescending(p => p.Params.Count).ToList();
        var ns = methodGroup.Key.Dehumanize();
        strFunc.AppendLine($"namespace {ns} {{");

        FunctionParser.GenerateFunction(strFunc, methods, groups);

        strFunc.AppendLine("}");
    }

    strFunc.AppendLine("}");

    await File.WriteAllTextAsync(funcPath, strFunc.ToString());
}

async Task GenerateTypes()
{
    var typesPath = Path.Combine(baseApiPath!, "Types.cs");

    var strTypes = new StringBuilder();
    strTypes.AppendLine($"using SharpGram.Core.Conversions;using SharpGram.Core.Contracts;\n" +
                        $"using Tel = SharpGram.Tl.Constructors;\n{warnings}\n\nnamespace SharpGram.Tl.Types;");

    foreach (var group in groups!)
    {
        var constructors = group.ToList();

        var commonProps = TypeParser.FindCommonParams(constructors);
        commonParams.Add(group.Key, commonProps);
        var derivedTypesName = constructors.Select(p => p.Name).Aggregate("", (current, d) => current + $"{d}, ");

        strTypes.Append($"/// derived Types: {derivedTypesName}\n    public abstract class {group.Key}Base");
        if (constructors.Count == 0)
        {
            strTypes.AppendLine(";");
            continue;
        }

        strTypes.AppendLine($" : ITlSerializable, ITlDeserializable<{group.Key}Base> {{");
        foreach (var common in commonProps)
            strTypes.AppendLine($"        public {common.Type} {common.Name} {{get;set;}} = default!;");


        strTypes.AppendLine($"        public static {group.Key}Base TlDeserialize(Deserializer des) {{");
        strTypes.AppendLine("            var id = des.ReadId();\n");
        foreach (var typeName in constructors.Select(ctor => $"Tel.{group.Key}Ns.{ctor.Name}"))
        {
            strTypes.AppendLine($"            if (id.SequenceEqual({typeName}.Identifier))");
            strTypes.AppendLine($"                return {typeName}.TlDeserialize(des);");
        }

        strTypes.AppendLine("            throw Core.Models.Errors.DeserializationException.InvalidCtor;");
        strTypes.AppendLine("        }");
        strTypes.AppendLine("        public byte[] TlSerialize() => this switch {");
        foreach (var ctor in constructors)
        {
            var varName = ctor.Name + Math.Abs(int.Parse(ctor.Id));
            strTypes.AppendLine($"            Tel.{group.Key}Ns.{ctor.Name} {varName} => {varName}.TlSerialize(),");
        }

        strTypes.AppendLine("            _=> [],\n        };");
        strTypes.AppendLine("    }");
    }

    await File.WriteAllTextAsync(typesPath!, strTypes.ToString());
}

async Task GenerateConstructors()
{
    var constructorPath = Path.Combine(baseApiPath!, "Constructors.cs");

    var strCtor = new StringBuilder();

//var ctorUsage = groups.Select(p => p.Key).Aggregate("", (c, key) => c + $"using SharpGram.Tl.Constructors.{key}Ns;");
    const string ctorUsage = $"using SharpGram.Core.Conversions;using SharpGram.Tl.Constructors.HelpPeerColorOptionNs;using SharpGram.Tl.Constructors.HelpCountryCodeNs;using SharpGram.Tl.Constructors.HelpCountryNs; using SharpGram.Tl.Types;using SharpGram.Core.Contracts;using SharpGram.Core.Conversions;\n{warnings}\n";
    strCtor.AppendLine(ctorUsage);

    foreach (var group in groups!)
    {
        strCtor.AppendLine($"namespace SharpGram.Tl.Constructors.{group.Key}Ns {{");

        var constructors = group.ToList();
        foreach (var type in constructors)
        {
            if (type.Name == "ChannelFull")
            {
                Console.WriteLine();
            }
            var commonProps = commonParams[group.Key];

            strCtor.AppendLine($"    public class {type.Name} : {group.Key}Base, ITlSerializable, ITlDeserializable<{type.Name}> {{");
            TypeParser.GenerateId(strCtor, type.Id, false);
            foreach (var param in type.Params.Where(p => !commonProps.Contains(p)).ToList()) //don't redefine inherited properties
            {
                if (param.IsFlag)
                    strCtor.AppendLine($"        private {param.Type} {param.Name};");
                else
                    strCtor.AppendLine($"        public{(param.IsNullable || param.Type == "bool" ? "": " required")} {param.Type} {param.Name} {{get;set;}}");
            }

            TypeParser.GenerateTlSerializer(strCtor, type.Params);
            strCtor.AppendLine($"\n        public new static {type.Name} TlDeserialize(Deserializer des) {{");

            strCtor.AppendLine("            ArgumentOutOfRangeException.ThrowIfNotEqual(des.IsCorrectId(Identifier), true);");
            foreach (var param in type.Params)
            {
                var paramType = param.Type.EndsWith('?') ? param.Type[..^1] : param.Type;


                string readerExpr;
                if (paramType.IsBuiltinType())
                    readerExpr = $"des.As<{paramType}>().Read()";
                else if (paramType.StartsWith("List<"))
                {
                    var innerType = paramType.Split('<')[1].Split('>')[0];
                    if (innerType.IsBuiltinType())
                    {
                        if (innerType is "int" or "long" or "double" or "uint")
                            readerExpr = $"des.ReadNumbers<{innerType}>()";
                        else if (innerType is "string")
                            readerExpr = "des.ReadStrings()";
                        else if (innerType is "byte[]")
                            readerExpr = "des.ReadByteArrayList()";
                        else
                            readerExpr = "default!";
                        //str bool ..etc
                    }
                    else
                        readerExpr = $"des.Read<{innerType}>()";
                }
                else if (paramType is "byte[]")
                    readerExpr = "des.As<byte[]>().Read()";
                else
                    readerExpr = $"{paramType}.TlDeserialize(des)";

                strCtor.Append($"            var {param.Name.Camelize()}Local = ");
                if (string.IsNullOrEmpty(param.FlagName) || param.IsFlag)
                    strCtor.AppendLine($" {readerExpr};");
                else
                {
                    strCtor.AppendLine($"({param.FlagName}Local & {param.FlagOffset}) is 0 ? default : {(param.Type == "bool" ? "true" : readerExpr)} ;");
                }
            }

            strCtor.AppendLine("            return new() {");
            foreach (var param in type.Params)
                strCtor.AppendLine($"            {param.Name} = {param.Name.Camelize()}Local,");

            strCtor.AppendLine("            };");

            strCtor.AppendLine("        }");

            strCtor.AppendLine("    }");
        }

        strCtor.AppendLine("\n");
        strCtor.AppendLine("}");
    }


    await File.WriteAllTextAsync(constructorPath, strCtor.ToString());
}

async Task GenerateMtProto()
{
    Console.WriteLine("are you sure?, you shouldn't replace the current mtproto impl");
    _ = Console.ReadLine() != "yes im sure" ? throw new Exception("don't do this") : "";

    var mtprotoTypePath = Path.Combine(baseApiPath!, "Mtproto.cs");
    TextParser.FixSchema(Schema.MtprotoSchema);

    foreach (var t in Schema.MtprotoSchema.Types)
    {
        t.Name = t.Name.Replace("DH", "Dh").Replace("PQ", "Pq");
        t.Type = t.Type.Replace("Msg", "Message").Replace("DH", "Dh");
        foreach (var param in t.Params)
        {
            param.Name = param.Name.Replace("GA", "Ga").Replace("GB", "Gb");
        }
    }

    foreach (var t in Schema.MtprotoSchema.Methods)
    {
        t.Name = t.Name.Replace("DH", "Dh").Replace("PQ", "Pq");
        t.Type = t.Type.Replace("Msg", "Message").Replace("DH", "Dh");
        foreach (var param in t.Params)
        {
            param.Name = param.Name.Replace("GA", "Ga").Replace("GB", "Gb");
        }
    }

    var mtprotoGroups = Schema.MtprotoSchema.Types.GroupBy(p => p.Type).OrderBy(p => p.Count()).Skip(1).ToList();

    var strMtproto = new StringBuilder($"using Int256 = SharpGram.Core.Models.Types.Int256;using Int128 = SharpGram.Core.Models.Types.Int128;using SharpGram.Core.Conversions;using SharpGram.Core.Contracts;" +
                                       $"\n{warnings} AutoPropertyCanBeMadeGetOnly.Global\n\nnamespace SharpGram.Tl.Mtproto;\n");
    foreach (var group in mtprotoGroups)
    {
        var baseType = group.Key + "Base";
        strMtproto.AppendLine($"public abstract partial class {baseType};");

        var types = group.ToList();
        foreach (var type in types)
        {
            strMtproto.AppendLine($"public sealed partial class {type.Name} : {baseType}, ITlSerializable {{");
            var len = strMtproto.Length;
            TypeParser.GenerateId(strMtproto, type.Id, false);
            strMtproto.Remove(len, 4);
            foreach (var param in type.Params)
            {
                strMtproto.AppendLine($"    public {param.Type} {param.Name} {{get;set;}} = default!;");
            }

            TypeParser.GenerateTlSerializer(strMtproto, type.Params, 1, false);
            strMtproto.AppendLine("}");
        }

        strMtproto.AppendLine("\n");
    }

    strMtproto.AppendLine("\n//Functions");
    foreach (var method in Schema.MtprotoSchema.Methods)
    {
        strMtproto.AppendLine($"public sealed partial class {method.Name} : ITlSerializable {{");
        var len = strMtproto.Length;
        TypeParser.GenerateId(strMtproto, method.Id, false);
        strMtproto.Remove(len, 4);
        foreach (var param in method.Params)
            strMtproto.AppendLine($"    public {param.Type} {param.Name} {{get;set;}} = default!;");
        TypeParser.GenerateTlSerializer(strMtproto, method.Params, 1, false);
        strMtproto.AppendLine("}");
    }

    await File.WriteAllTextAsync(mtprotoTypePath, strMtproto.ToString());
}