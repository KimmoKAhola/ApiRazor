using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ApiRazor.RapidMovies;

public class Result
{
    // [JsonProperty("_id")]
    // [JsonPropertyName("_id")]
    // public string Id { get; set; }

    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonProperty("primaryImage")]
    [JsonPropertyName("primaryImage")]
    public PrimaryImage PrimaryImage { get; set; }

    [JsonProperty("titleType")]
    [JsonPropertyName("titleType")]
    public TitleType TitleType { get; set; }

    [JsonProperty("titleText")]
    [JsonPropertyName("titleText")]
    public TitleText TitleText { get; set; }

    [JsonProperty("originalTitleText")]
    [JsonPropertyName("originalTitleText")]
    public OriginalTitleText OriginalTitleText { get; set; }

    [JsonProperty("releaseYear")]
    [JsonPropertyName("releaseYear")]
    public ReleaseYear ReleaseYear { get; set; }

    [JsonProperty("releaseDate")]
    [JsonPropertyName("releaseDate")]
    public ReleaseDate ReleaseDate { get; set; }
}