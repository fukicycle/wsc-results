using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace wsc_results.Models
{
    public class WsEntity
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public Name Name { get; set; } = null!;

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("links")]
        public List<object> Links { get; set; } = null!;
    }
}
