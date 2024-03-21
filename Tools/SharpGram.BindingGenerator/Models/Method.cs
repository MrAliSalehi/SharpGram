using System.Text.Json.Serialization;

namespace SharpGram.BindingGenerator.Models;
#nullable disable
public class Method
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("method")]
    public string Name { get; set; }

    [JsonPropertyName("params")]
    public List<Param> Params { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonIgnore]
    public string NameSpace { get; set; }
}