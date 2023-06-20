using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace wsc_results.Models
{
    public class Link
    {
        [JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("rel")]
        public string Rel { get; set; } = null!;

        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("href")]
        public string Href { get; set; } = null!;

        [JsonProperty("content_type", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("content_type")]
        public object ContentType { get; set; } = null!;

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("description")]
        public object Description { get; set; } = null!;
    }
}
