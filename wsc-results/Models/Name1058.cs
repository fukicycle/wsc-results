using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace wsc_results.Models
{

    public class Name1058
    {
        [JsonProperty("lang_code", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("lang_code")]
        public string LangCode { get; set; } = null!;

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("text")]
        public string Text { get; set; } = null!;
    }
}
