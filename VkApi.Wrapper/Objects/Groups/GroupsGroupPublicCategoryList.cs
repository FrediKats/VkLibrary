using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GroupsGroupPublicCategoryList
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("subcategories")]
        public GroupsGroupCategoryType[] Subcategories { get; set; }
    }
}