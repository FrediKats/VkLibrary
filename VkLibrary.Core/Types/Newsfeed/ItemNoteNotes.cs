using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Newsfeed
{
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