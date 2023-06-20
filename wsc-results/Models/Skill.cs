using Newtonsoft.Json;
using System.Text.Json.Serialization;
using wsc_results.Models;

namespace wsc_results.Models
{
    public class Skill
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("event")]
        public Event Event { get; set; } = null!;

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("type")]
        public string Type { get; set; } = null!;

        [JsonProperty("base_id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("base_id")]
        public int BaseId { get; set; }

        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("number")]
        public string Number { get; set; } = null!;

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public Name Name { get; set; } = null!;

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("links")]
        public List<object> Links { get; set; } = null!;
    }
}
