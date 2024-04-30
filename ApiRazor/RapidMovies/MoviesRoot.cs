using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ApiRazor.RapidMovies;

public class MoviesRoot
{
    [JsonProperty("page")]
    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonProperty("next")]
    [JsonPropertyName("next")]
    public string Next { get; set; }

    [JsonProperty("entries")]
    [JsonPropertyName("entries")]
    public int Entries { get; set; }

    [JsonProperty("results")]
    [JsonPropertyName("results")]
    public List<Result> Results { get; set; }
}