using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class FaveTag
    {
        ///<summary>
        /// Tag id
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Tag name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}