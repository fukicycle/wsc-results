using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace wsc_results.Models
{
    public class Root
    {
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("results")]
        public List<Result> Results { get; set; } = null!;

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("notes")]
        public List<object> Notes { get; set; } = null!;

        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("links")]
        public List<object> Links { get; set; } = null!;
    }
}