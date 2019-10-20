using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class CallbackGroupChangePhoto
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("photo")]
        public PhotosPhoto Photo { get; set; }
    }
}