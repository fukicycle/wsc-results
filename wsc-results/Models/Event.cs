using Newtonsoft.Json;

namespace wsc_results.Models
{
    public class Event
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("ws_entity")]
        public WsEntity WsEntity { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }
    }
}
