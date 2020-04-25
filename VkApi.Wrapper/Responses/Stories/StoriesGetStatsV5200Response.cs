using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class StoriesGetStatsV5200Response
    {
        [JsonProperty("preview")]
        public String Preview { get; set; }
        [JsonProperty("achievement")]
        public String Achievement { get; set; }
        [JsonProperty("achievement_subtitle")]
        public String AchievementSubtitle { get; set; }
        //TODO: Fix
        //[JsonProperty("categories")]
        //public StoriesStatCategory[] Categories { get; set; }
    }
}