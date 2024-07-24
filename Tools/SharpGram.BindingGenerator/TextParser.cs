using Humanizer;
using SharpGram.BindingGenerator.Models;

namespace SharpGram.BindingGenerator;

public static class TextParser
{
    private static string FixType(this string type)
    {
        if (string.IsNullOrEmpty(type)) return type;

        if (type.Contains("Vector", StringComparison.OrdinalIgnoreCase)) type = type.Replace("Vector", "List", StringComparison.OrdinalIgnoreCase);
        var split = type.Split('<');
        if (split.Length > 1) //its generic
        {
            var inner = split[1].Split('>')[0].ReplaceBuiltinTypes();
            if (!inner.IsBuiltinType()) inner = inner.Dehumanize();
            type = $"{split[0]}<{inner}>";
            return type;
        }

        return type.Dehumanize().ReplaceBuiltinTypes();
    }
    public static void FixSchema(TelegramSchema schema)
    {
        foreach (var ctor in schema.Types)
        {
            ctor.Name = ctor.Name.Dehumanize();
            ctor.Type = ctor.Type.FixType();
            ctor.Params.ParseParams(ctor.Name);
        }

        foreach (var method in schema.Methods)
        {

            method.NameSpace = method.Name.Split('.')[0].Dehumanize();
            method.Name = method.Name.Dehumanize();

            if (!method.Type.IsBuiltinType())
            {
                if (method.Type.Contains('.'))
                {
                    if (char.IsUpper(method.Type.Split('.')[1][0]))
                        method.Type += "Base";
                }
                else if (method.Type.StartsWith("List") || method.Type.StartsWith("Vector"))
                {
                    var inner = method.Type.Split('<')[1].Split('>')[0].ReplaceBuiltinTypes();

                    if (inner.Contains('.'))
                    {
                        if (char.IsUpper(inner.Split('.')[1][0]))
                            method.Type = $"List<{inner}Base>";
                    }
                    else if (char.IsUpper(inner[0]))
                    {
                        method.Type = $"List<{inner}Base>";
                    }
                }
                else if (char.IsUpper(method.Type[0]))
                    method.Type += "Base";
            }

            method.Type = method.Type.FixType();
            method.Params.ParseParams(method.Name);
        }
    }
    private static void ParseParams(this List<Param> t, string className)
    {
        foreach (var tParam in t)
        {
            if (!string.IsNullOrEmpty(tParam.Type))
            {
                bool isBaseType;
                if (tParam.Type.StartsWith("Vector"))
                    isBaseType = char.IsUpper(tParam.Type.Split('<')[1].Split('>')[0][0]);
                else
                {
                    if (tParam.Type.Contains('.'))
                        isBaseType = char.IsUpper(tParam.Type.Split('.')[1][0]);
                    else
                        isBaseType = char.IsUpper(tParam.Type[0]) && !tParam.Type.IsBuiltinType();
                }

                if (tParam.Type is "#")
                {
                    tParam.IsFlag = true;
                    tParam.Type = "int";
                }
                else if (tParam.Type != "flags" && tParam.Type != "flags2" && tParam.Type.StartsWith("flags"))
                {
                    var sp = tParam.Type.Split('?');
                    var spl2 = sp[1].Split('<');
                    if (spl2.Length > 1)
                    {
                        if (char.IsUpper(spl2[1].Split('>')[0][0]))
                            sp[1] = $"{spl2[0]}<{spl2[1].Replace(">", "Base")}>";
                    }
                    else
                    {
                        if (sp[1].Contains('.'))
                            isBaseType = char.IsUpper(sp[1].Split('.')[1][0]);
                        else
                            isBaseType = char.IsUpper(sp[1][0]) && !sp[1].IsBuiltinType();
                    }

                    var flg = sp[0].Split('.');
                    tParam.FlagName = flg[0];
                    tParam.FlagOffset = 1 << int.Parse(flg[1]);
                    var fixedPart = sp[1].FixType();
                    tParam.IsNullable = !fixedPart.Contains("bool", StringComparison.OrdinalIgnoreCase);
                    if (tParam.IsNullable)
                        fixedPart += '?';
                    tParam.Type = fixedPart;
                }
                else
                    tParam.Type = tParam.Type.FixType();

                if (isBaseType)
                    if (tParam.Type.EndsWith('?'))
                        tParam.Type = tParam.Type.Replace("?", "Base?");
                    else if (tParam.Type.EndsWith('>'))
                        tParam.Type = tParam.Type.Replace(">", "Base>");
                    else
                        tParam.Type += "Base";
            }

            if (!string.IsNullOrEmpty(tParam.Name))
            {
                tParam.Name = tParam.Name.Dehumanize();
                if (tParam.Name.Equals(className, StringComparison.OrdinalIgnoreCase))
                    tParam.Name += "Inner";
            }
        }
    }

    private static string ReplaceBuiltinTypes(this string type) => type switch
    {
        "String"                                         => "string",
        "Bytes" or "bytes"                               => "byte[]",
        "Int"                                            => "int",
        "Null"                                           => "null",
        "Long"                                           => "long",
        "Bool" or "True" or "true" or "false" or "False" => "bool",
        "Double"                                         => "double",
        "Object"                                         => "object",
        "vector" or "Vector"                             => "List",
        _                                                => type
    };
    public static bool IsBuiltinType(this string type) =>
        type.Equals("string", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("bytes", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("int", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("null", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("long", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("bool", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("bytes", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("vector t", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("true", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("false", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("error", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("object", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("byte[]", StringComparison.CurrentCultureIgnoreCase) ||
        type.Equals("double", StringComparison.CurrentCultureIgnoreCase);
}