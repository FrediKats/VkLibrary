using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class CallbackVideoCommentDelete
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("video_id")]
        public int VideoId { get; set; }
    }
}