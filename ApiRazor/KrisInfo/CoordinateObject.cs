using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class CoordinateObject
{
    [JsonProperty("Latitude")]
    [JsonPropertyName("Latitude")]
    public string Latitude { get; set; }

    [JsonProperty("Longitude")]
    [JsonPropertyName("Longitude")]
    public string Longitude { get; set; }

    [JsonProperty("Altitude")]
    [JsonPropertyName("Altitude")]
    public string Altitude { get; set; }
}