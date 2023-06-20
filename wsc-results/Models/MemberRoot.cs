using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace wsc_results.Models
{
    public class MemberRoot
    {
        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("members")]
        public List<Member> Members { get; set; } = null!;
    }
}
