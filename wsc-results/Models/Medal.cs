using Newtonsoft.Json;

namespace wsc_results.Models
{
    public class Medal
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }
    }
}
