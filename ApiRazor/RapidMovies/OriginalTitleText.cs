using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ApiRazor.RapidMovies;

public class OriginalTitleText
{
    [JsonProperty("text")]
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonProperty("__typename")]
    [JsonPropertyName("__typename")]
    public string Typename { get; set; }
}