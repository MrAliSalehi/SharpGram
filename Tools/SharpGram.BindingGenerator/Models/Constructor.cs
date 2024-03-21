using System.Text.Json.Serialization;

namespace SharpGram.BindingGenerator.Models;

#nullable disable
public class Constructor
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("predicate")]
    public string Name { get; set; }

    [JsonPropertyName("params")]
    public List<Param> Params { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}