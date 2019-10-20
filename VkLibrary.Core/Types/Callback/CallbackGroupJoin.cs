using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class CallbackGroupJoin
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("join_type")]
        public CallbackGroupJoinType JoinType { get; set; }
    }
}