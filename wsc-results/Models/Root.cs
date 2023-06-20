using Newtonsoft.Json;

namespace wsc_results.Models
{
    public class Root
    {
        [JsonProperty("results")]
        public List<Result> Results { get; set; }

        [JsonProperty("notes")]
        public List<object> Notes { get; set; }

        [JsonProperty("total_count")]
        public int? TotalCount { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }
    }
}