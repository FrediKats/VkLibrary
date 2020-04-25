using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemWallpostFeedbackAnswer
    {
        [JsonProperty("title")]
        public String Title { get; set; }
        [JsonProperty("id")]
        public String Id { get; set; }
    }
}