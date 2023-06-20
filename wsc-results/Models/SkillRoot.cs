using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace wsc_results.Models
{
    public class SkillRoot
    {
        [JsonProperty("base_skills", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("base_skills")]
        public List<WsEntity> BaseSkills { get; set; } = null!;
    }
}
