using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ApiRazor.RapidMovies;

public class Caption
{
    [JsonProperty("plainText")]
    [JsonPropertyName("plainText")]
    public string PlainText { get; set; }

    [JsonProperty("__typename")]
    [JsonPropertyName("__typename")]
    public string Typename { get; set; }
}