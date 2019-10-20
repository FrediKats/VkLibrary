using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UtilsDomainResolved
    {
        ///<summary>
        /// Object ID
        ///</summary>
        [JsonProperty("object_id")]
        public int ObjectId { get; set; }
        [JsonProperty("type")]
        public UtilsDomainResolvedType Type { get; set; }
    }
}