using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class BaseObject
    {
        ///<summary>
        /// Object ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Object title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}