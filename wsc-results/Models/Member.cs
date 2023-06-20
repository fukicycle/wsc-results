using Newtonsoft.Json;
using wsc_results.Models;

namespace wsc_results.Models
{
    public class Member
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("name_1058")]
        public Name1058 Name1058 { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("flag")]
        public Flag Flag { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }
    }
}
