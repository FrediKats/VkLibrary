using System;
using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed 
{
    public class ItemNoteNotes
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<NewsfeedNote> Items { get; set; }

        /// <summary>
        /// Notes number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
