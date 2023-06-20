using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace wsc_results.Models
{
    public class Competitor
    {
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; } = null!;

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; } = null!;

        [JsonProperty("person_id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("person_id")]
        public int? PersonId { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("image")]
        public Image Image { get; set; } = null!;
    }
}
