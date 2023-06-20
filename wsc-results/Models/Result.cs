using Newtonsoft.Json;

namespace wsc_results.Models
{
    public class Result
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("competitors")]
        public List<Competitor> Competitors { get; set; }

        [JsonProperty("member")]
        public Member Member { get; set; }

        [JsonProperty("medal")]
        public Medal Medal { get; set; }

        [JsonProperty("mark")]
        public double? Mark { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("best_of_nation")]
        public bool? BestOfNation { get; set; }

        [JsonProperty("albert_vidal_award")]
        public bool? AlbertVidalAward { get; set; }

        [JsonProperty("published")]
        public bool? Published { get; set; }

        [JsonProperty("skill")]
        public Skill Skill { get; set; }

        [JsonProperty("note_ids")]
        public List<object> NoteIds { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }
    }
}
