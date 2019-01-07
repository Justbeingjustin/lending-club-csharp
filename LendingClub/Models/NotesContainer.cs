using Newtonsoft.Json;
using System.Collections.Generic;

namespace LendingClub.Models
{
    public class NotesContainer
    {
        [JsonProperty("myNotes")]
        private List<Note> Notes { get; set; }
    }
}