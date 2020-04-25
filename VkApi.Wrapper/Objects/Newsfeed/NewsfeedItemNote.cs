using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemNote
    {
        [JsonProperty("notes")]
        public NewsfeedItemNoteNotes Notes { get; set; }
    }
}