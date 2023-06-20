using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace wsc_results.Models
{
    public class Event
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; } = null!;

        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; } = null!;

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("code")]
        public string Code { get; set; } = null!;

        [JsonProperty("ws_entity", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("ws_entity")]
        public WsEntity WsEntity { get; set; } = null!;

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("links")]
        public List<object> Links { get; set; } = null!;
    }
}
