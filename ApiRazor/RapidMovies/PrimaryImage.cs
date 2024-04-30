using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ApiRazor.RapidMovies;

public class PrimaryImage
{
    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonProperty("width")]
    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonProperty("height")]
    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonProperty("url")]
    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonProperty("caption")]
    [JsonPropertyName("caption")]
    public Caption Caption { get; set; }

    [JsonProperty("__typename")]
    [JsonPropertyName("__typename")]
    public string Typename { get; set; }
}