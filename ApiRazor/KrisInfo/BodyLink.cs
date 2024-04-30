using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class BodyLink
{
    [JsonProperty("Text")]
    [JsonPropertyName("Text")]
    public string Text { get; set; }

    [JsonProperty("Url")]
    [JsonPropertyName("Url")]
    public string Url { get; set; }
}