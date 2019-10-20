using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class CallbackMessageDeny
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}