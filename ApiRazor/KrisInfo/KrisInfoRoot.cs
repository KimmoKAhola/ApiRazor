using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class KrisInfoRoot
{
    [JsonProperty("Identifier")]
    [JsonPropertyName("Identifier")]
    public string Identifier { get; set; }

    [JsonProperty("PushMessage")]
    [JsonPropertyName("PushMessage")]
    public string PushMessage { get; set; }

    [JsonProperty("Updated")]
    [JsonPropertyName("Updated")]
    public DateTime Updated { get; set; }

    [JsonProperty("Published")]
    [JsonPropertyName("Published")]
    public DateTime Published { get; set; }

    [JsonProperty("Headline")]
    [JsonPropertyName("Headline")]
    public string Headline { get; set; }

    [JsonProperty("Preamble")]
    [JsonPropertyName("Preamble")]
    public string Preamble { get; set; }

    [JsonProperty("BodyText")]
    [JsonPropertyName("BodyText")]
    public string BodyText { get; set; }

    [JsonProperty("ImageLink")]
    [JsonPropertyName("ImageLink")]
    public string ImageLink { get; set; }

    [JsonProperty("Links")]
    [JsonPropertyName("Links")]
    public List<Link> Links { get; set; }

    [JsonProperty("Area")]
    [JsonPropertyName("Area")]
    public List<Area> Area { get; set; }

    [JsonProperty("Web")]
    [JsonPropertyName("Web")]
    public string Web { get; set; }

    [JsonProperty("Language")]
    [JsonPropertyName("Language")]
    public string Language { get; set; }

    [JsonProperty("Event")]
    [JsonPropertyName("Event")]
    public string Event { get; set; }

    [JsonProperty("SenderName")]
    [JsonPropertyName("SenderName")]
    public string SenderName { get; set; }

    [JsonProperty("Push")]
    [JsonPropertyName("Push")]
    public bool Push { get; set; }

    [JsonProperty("BodyLinks")]
    [JsonPropertyName("BodyLinks")]
    public List<BodyLink> BodyLinks { get; set; }

    [JsonProperty("SourceID")]
    [JsonPropertyName("SourceID")]
    public int SourceID { get; set; }

    [JsonProperty("IsTest")]
    [JsonPropertyName("IsTest")]
    public bool IsTest { get; set; }
}