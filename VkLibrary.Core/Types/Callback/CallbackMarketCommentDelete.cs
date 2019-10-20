using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class CallbackMarketCommentDelete
    {
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("item_id")]
        public int ItemId { get; set; }
    }
}