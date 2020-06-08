using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemNote : NewsfeedItemBase
    {
        [JsonProperty("notes")]
        public NewsfeedItemNoteNotes Notes { get; set; }
    }
}