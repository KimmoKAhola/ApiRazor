using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ApiRazor.RapidMovies;

public class ReleaseDate
{
    [JsonProperty("day")]
    [JsonPropertyName("day")]
    public object Day { get; set; }

    [JsonProperty("month")]
    [JsonPropertyName("month")]
    public int? Month { get; set; }

    [JsonProperty("year")]
    [JsonPropertyName("year")]
    public int Year { get; set; }

    [JsonProperty("__typename")]
    [JsonPropertyName("__typename")]
    public string Typename { get; set; }
}