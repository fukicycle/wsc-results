using Newtonsoft.Json;
using wsc_results.Models;

namespace wsc_results.Models
{
    public class Skill
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("event")]
        public Event Event { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("base_id")]
        public int? BaseId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }
    }
}
