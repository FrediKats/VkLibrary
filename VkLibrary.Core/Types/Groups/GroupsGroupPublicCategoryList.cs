using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
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