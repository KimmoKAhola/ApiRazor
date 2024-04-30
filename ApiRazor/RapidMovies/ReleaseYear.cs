using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ApiRazor.RapidMovies;

public class ReleaseYear
{
    [JsonProperty("year")]
    [JsonPropertyName("year")]
    public int Year { get; set; }

    [JsonProperty("endYear")]
    [JsonPropertyName("endYear")]
    public object EndYear { get; set; }

    [JsonProperty("__typename")]
    [JsonPropertyName("__typename")]
    public string Typename { get; set; }
}