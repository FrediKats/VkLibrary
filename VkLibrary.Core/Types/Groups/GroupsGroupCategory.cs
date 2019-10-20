using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
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