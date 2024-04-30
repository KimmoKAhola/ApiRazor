using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class Area
{
    [JsonProperty("Type")]
    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [JsonProperty("Description")]
    [JsonPropertyName("Description")]
    public string Description { get; set; }

    [JsonProperty("Coordinate")]
    [JsonPropertyName("Coordinate")]
    public string Coordinate { get; set; }

    [JsonProperty("CoordinateObject")]
    [JsonPropertyName("CoordinateObject")]
    public CoordinateObject CoordinateObject { get; set; }

    [JsonProperty("GeometryInformation")]
    [JsonPropertyName("GeometryInformation")]
    public object GeometryInformation { get; set; }
}