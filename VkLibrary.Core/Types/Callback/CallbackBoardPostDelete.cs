using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class CallbackBoardPostDelete
    {
        [JsonProperty("topic_owner_id")]
        public int TopicOwnerId { get; set; }
        [JsonProperty("topic_id")]
        public int TopicId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}