using Newtonsoft.Json;

namespace wsc_results.Models
{
    public class Image
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
