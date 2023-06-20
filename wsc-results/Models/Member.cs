using Newtonsoft.Json;
using System.Text.Json.Serialization;
using wsc_results.Models;

namespace wsc_results.Models
{
    public class Member
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public Name Name { get; set; } = null!;

        [JsonProperty("name_1058", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name_1058")]
        public Name1058 Name1058 { get; set; } = null!;

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("code")]
        public string Code { get; set; } = null!;

        [JsonProperty("flag", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("flag")]
        public Flag Flag { get; set; } = null!;

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("links")]
        public List<object> Links { get; set; } = null!;
    }
}
