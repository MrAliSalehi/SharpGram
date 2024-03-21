using System.Text.Json.Serialization;

namespace SharpGram.BindingGenerator.Models;
#nullable disable
public class TelegramSchema
{
    [JsonPropertyName("constructors")]
    public List<Constructor> Types { get; set; }

    [JsonPropertyName("methods")]
    public List<Method> Methods { get; set; }
}