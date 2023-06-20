using Newtonsoft.Json;

namespace wsc_results.Models
{
    public class WsEntity
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }
    }
}
