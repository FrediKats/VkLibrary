using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsGroupCategory
    {
        ///<summary>
        /// Category ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Category name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("subcategories")]
        public BaseObjectWithName[] Subcategories { get; set; }
    }
}