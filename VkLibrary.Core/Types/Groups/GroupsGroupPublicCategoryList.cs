using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsGroupPublicCategoryList
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("subtypes_list")]
        public GroupsGroupCategoryType[] SubtypesList { get; set; }
    }
}