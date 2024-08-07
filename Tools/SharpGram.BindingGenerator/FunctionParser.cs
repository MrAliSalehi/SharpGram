using System.Text;
using SharpGram.BindingGenerator.Models;

namespace SharpGram.BindingGenerator;

public static class FunctionParser
{
    public static void GenerateFunction(StringBuilder b, List<Method> methods, List<IGrouping<string, Constructor>> groups)
    {
        foreach (var method in methods)
        {
            var returnType = method.Type;
            switch (returnType)
            {
                case "bool":
                    returnType = "TlBool";
                    break;
                case "long":
                    returnType = "TlLong";
                    break;
                case "int":
                    returnType = "TlInt";
                    break;
                default:
                    var isList = returnType.StartsWith("List");
                    var isBase = returnType.Contains("Base");
                    if (isList)
                        returnType = returnType.Replace("List", "TlList");
                    if (!returnType.IsBuiltinType() && !isList && !isBase)
                    {
                        var ns = groups.FindNamespace(returnType);
                        returnType = $"Tel.{ns}Ns.{returnType}";
                    }
                    else if (isList && !isBase)
                    {
                        var innerType = returnType.Split('<')[1].Split('>')[0];
                        if (innerType.IsBuiltinType())
                        {
                            if (innerType is "long")
                                returnType = "TlList<TlLong>";
                            else if (innerType is "int")
                                returnType = "TlList<TlInt>";
                            else if (innerType is "bool")
                                returnType = "TlList<TlBool>";
                        }
                        else
                        {
                            var ns = groups.FindNamespace(innerType);
                            returnType = $"TlList<Tel.{ns}Ns.{innerType}>";
                        }
                    }

                    break;
            }


            b.Append($"        public sealed class {method.Name} : TlFunction<{returnType}> {{\n    ");
            TypeParser.GenerateId(b, method.Id, false);

            foreach (var param in method.Params.Where(param => !param.IsFlag))
            {
                var cantBeNull = param.Type.IsBuiltinType() && param.Type is not ("string" or "byte[]");
                b.AppendLine($"            public{(param.IsNullable || cantBeNull ? "" : " required")} {param.Type} {param.Name} {{get;set;}}");
            }


            var space = new string(' ', 4 * 3);
            b.AppendLine($"{space}public override byte[] TlSerialize() {{");

            b.AppendLine($"{space}    List<byte> bytes = [];");
            b.AppendLine($"{space}    bytes.AddRange(Identifier);");

            foreach (var param in method.Params)
            {
                if (param.IsFlag)
                {
                    var pm = method.Params.Where(p => p is { IsFlag: false, IsNullable: true }).ToList();
                    if (pm.Count == 0)
                    {
                        b.AppendLine($"{space}    bytes.AddRange(0.TlSerialize());");
                    }else
                    {
                        b.Append($"{space}    bytes.AddRange((0 |");
                        foreach (var (param2, i) in pm.Select((v, i) => (v, i)))
                        {
                            b.Append($" ({param2.Name}{(param2.IsNullable ? " is not null" : "")} ? {param2.FlagOffset} : 0) ");
                            if (i +1 < pm.Count)
                                b.Append('|');
                        }
                        b.AppendLine(").TlSerialize());");
                    }

                    continue;
                }
                if (param.Type is "bool") continue; // they are set through flags
                if (param.IsNullable)
                    b.AppendLine($"{space}    if({param.Name} is not null) bytes.AddRange({param.Name}.TlSerialize());");
                else
                    b.AppendLine($"{space}    bytes.AddRange({param.Name}.TlSerialize());");
            }

            b.AppendLine($"{space}    return bytes.ToArray();");

            b.AppendLine($"{space}}}");
            b.AppendLine("        }");
        }
    }
}