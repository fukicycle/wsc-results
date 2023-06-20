using Newtonsoft.Json;

namespace wsc_results.Models
{
    public class Competitor
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("person_id")]
        public int? PersonId { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }
    }
}
