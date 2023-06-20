using Newtonsoft.Json;

namespace wsc_results.Models
{
    public class Name
    {
        [JsonProperty("lang_code")]
        public string LangCode { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

}
