using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace wsc_results.Models
{
    public class Result
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("competitors", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("competitors")]
        public List<Competitor> Competitors { get; set; } = null!;

        [JsonProperty("member", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("member")]
        public Member Member { get; set; } = null!;

        [JsonProperty("medal", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("medal")]
        public Medal Medal { get; set; } = null!;

        [JsonProperty("mark", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("mark")]
        public double Mark { get; set; }

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonProperty("best_of_nation", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("best_of_nation")]
        public bool BestOfNation { get; set; }

        [JsonProperty("albert_vidal_award", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("albert_vidal_award")]
        public bool AlbertVidalAward { get; set; }

        [JsonProperty("published", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("published")]
        public bool Published { get; set; }

        [JsonProperty("skill", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("skill")]
        public Skill Skill { get; set; } = null!;

        [JsonProperty("note_ids", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("note_ids")]
        public List<object> NoteIds { get; set; } = null!;

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("links")]
        public List<object> Links { get; set; } = null!;
    }
}
