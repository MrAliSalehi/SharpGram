using System.Text;
using SharpGram.BindingGenerator.Models;
using SharpGram.Core.Conversions;

namespace SharpGram.BindingGenerator;

public static class TypeParser
{
    public static List<Param> FindCommonParams(List<Constructor> constructors)
    {
        HashSet<Param> commonParams = [];
        Dictionary<int, int> count = [];
        foreach (var constructor in constructors)
        {
            foreach (var param in constructor.Params)
            {
                var hash = param.GetHashCode();
                if (count.TryGetValue(hash, out var c))
                    count[hash] = c + 1;
                else
                    count.Add(hash, 1);
                commonParams.Add(param);
            }
        }

        List<Param> output = [];
        output.AddRange(from common in commonParams let c = count[common.GetHashCode()] where c > 1 select common);

        List<Param> output2 = [];
        output2.AddRange(output.Where(param => !output.Any(p => p.Type != param.Type && p.Name == param.Name)));

        List<Param> output3 = [];
        foreach (var param in output2)
        {
            if (constructors.TrueForAll(p => p.Params.Contains(param)))
                output3.Add(param);
        }

        return output3;
    }
    public static void GenerateId(StringBuilder b, string id, bool @new)
    {
        b.Append($"        public {(@new ? "new " : "")}static readonly byte[] Identifier = [");
        var idArr = int.Parse(id).TlSerialize();
        foreach (var byt in idArr)
            b.Append($"{byt},");
        b.AppendLine("];");
    }
    public static void GenerateTlSerializer(StringBuilder b, List<Param> parameters, int indent = 2, bool @new = true)
    {
        var space = new string(' ', 4 * indent);
        b.AppendLine($"{space}public{(@new ? " new" : "")} byte[] TlSerialize() {{");

        b.AppendLine($"{space}    List<byte> bytes = [];");
        b.AppendLine($"{space}    bytes.AddRange(Identifier);");

        foreach (var param in parameters)
        {
            if (param.IsFlag)
            {
                var pm = parameters.Where(p => p is { IsFlag: false, IsNullable: true }).ToList();
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
    }
    public static List<IGrouping<string, Constructor>> Group(TelegramSchema schema) => schema.Types
        .GroupBy(p => p.Type)
        .Where(g => !g.Key.IsBuiltinType())
        .ToList();
    public static string? FindNamespace(this List<IGrouping<string, Constructor>> list, string type)
    {
        return list
            .Where(group =>
                       group.ToList()
                           .Any(ctor => ctor.Name.Equals(type, StringComparison.OrdinalIgnoreCase)))
            .Select(group => group.Key)
            .FirstOrDefault();
    }
}