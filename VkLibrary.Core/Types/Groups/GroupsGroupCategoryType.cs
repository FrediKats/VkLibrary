using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsGroupCategoryType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}