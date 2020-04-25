using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BaseObjectWithName
    {
        ///<summary>
        /// Object ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Object name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}