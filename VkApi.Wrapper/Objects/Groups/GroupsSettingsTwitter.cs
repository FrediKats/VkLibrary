using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GroupsSettingsTwitter
    {
        [JsonProperty("status")]
        public String Status { get; set; }
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}