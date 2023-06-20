using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace wsc_results.Models
{
    public class EventRoot
    {
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("events")]
        public List<Event> Events { get; set; } = null!;
    }
}
