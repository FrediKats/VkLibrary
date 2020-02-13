using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsTokenPermissionSetting
    {
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("setting")]
        public int Setting { get; set; }
    }
}