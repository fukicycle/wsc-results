using Newtonsoft.Json;
using wsc_results.Models;

namespace wsc_results.Models
{
    public class Flag
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("thumbnail_hash")]
        public string ThumbnailHash { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }
    }


}
