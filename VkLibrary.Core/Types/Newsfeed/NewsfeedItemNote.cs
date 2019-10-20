using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class NewsfeedItemNote
    {
        [JsonProperty("notes")]
        public NewsfeedItemNoteNotes Notes { get; set; }
    }
}