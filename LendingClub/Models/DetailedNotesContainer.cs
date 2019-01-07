using Newtonsoft.Json;
using System.Collections.Generic;

namespace LendingClub.Models
{
    public class DetailedNotesContainer
    {
        [JsonProperty("myNotes")]
        private List<DetailedNote> DetailedNotes { get; set; }
    }
}