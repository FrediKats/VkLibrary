using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Newsfeed
{
    /// <summary>
    /// API ItemNoteNotes object.
    /// </summary>
    public class ItemNoteNotes
    {
        /// <summary>
        /// Notes number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<NewsfeedNote> Items { get; set; }
    }
}