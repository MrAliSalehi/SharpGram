using System.Text.Json.Serialization;

namespace SharpGram.BindingGenerator.Models;
#nullable disable
public sealed class Param : IEquatable<Param>
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonIgnore]
    public bool Inherited { get; set; }

    [JsonIgnore]
    public bool IsFlag { get; set; } // name is flags or flags2 && type = #

    [JsonIgnore]
    public int FlagOffset { get; set; }

    /// <summary>
    /// can be either flags or flags2
    /// </summary>
    [JsonIgnore]
    public string FlagName { get; set; } = "";

    [JsonIgnore]
    public bool IsNullable { get; set; } // type starts with flags or flags2

    public bool Equals(Param other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name && Type == other.Type;
    }
    public override bool Equals(object obj) => ReferenceEquals(this, obj) || obj is Param other && Equals(other);
    public override int GetHashCode() => HashCode.Combine(Name, Type);
}