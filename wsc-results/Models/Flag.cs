using Newtonsoft.Json;
using System.Text.Json.Serialization;
using wsc_results.Models;

namespace wsc_results.Models
{
    public class Flag
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("thumbnail_hash", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("thumbnail_hash")]
        public string ThumbnailHash { get; set; } = null!;

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; } = null!;

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("links")]
        public List<Link> Links { get; set; } = null!;
    }


}
