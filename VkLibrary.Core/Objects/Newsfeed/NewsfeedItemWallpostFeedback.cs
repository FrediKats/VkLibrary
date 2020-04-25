using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemWallpostFeedback
    {
        [JsonProperty("type")]
        public NewsfeedItemWallpostFeedbackType Type { get; set; }
        [JsonProperty("question")]
        public String Question { get; set; }
        [JsonProperty("answers")]
        public NewsfeedItemWallpostFeedbackAnswer[] Answers { get; set; }
        [JsonProperty("stars_count")]
        public int StarsCount { get; set; }
        [JsonProperty("gratitude")]
        public String Gratitude { get; set; }
    }
}