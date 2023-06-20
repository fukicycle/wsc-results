using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace wsc_results.Models
{
    public class Medal
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("code")]
        public string Code { get; set; } = null!;

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("name")]
        public Name Name { get; set; } = null!;
    }
}
