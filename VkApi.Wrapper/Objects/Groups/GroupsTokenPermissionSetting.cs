using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GroupsTokenPermissionSetting
    {
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("setting")]
        public int Setting { get; set; }
    }
}