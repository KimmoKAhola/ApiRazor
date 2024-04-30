using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ApiRazor.RapidMovies;

public class TitleType
{
    [JsonProperty("text")]
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonProperty("isSeries")]
    [JsonPropertyName("isSeries")]
    public bool IsSeries { get; set; }

    [JsonProperty("isEpisode")]
    [JsonPropertyName("isEpisode")]
    public bool IsEpisode { get; set; }

    [JsonProperty("__typename")]
    [JsonPropertyName("__typename")]
    public string Typename { get; set; }
}