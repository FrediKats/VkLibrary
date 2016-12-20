using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Newsfeed 
{
    public class ItemNote
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("notes")]
        public VkLib.Types.Newsfeed.ItemNoteNotes Notes { get; set; }

    }
}
