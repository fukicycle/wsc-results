using Newtonsoft.Json;

namespace wsc_results.Models
{
    public class Link
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("content_type")]
        public object ContentType { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }
    }
}
