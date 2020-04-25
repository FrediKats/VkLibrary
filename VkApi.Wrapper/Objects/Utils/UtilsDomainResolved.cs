using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class UtilsDomainResolved
    {
        ///<summary>
        /// Object ID
        ///</summary>
        [JsonProperty("object_id")]
        public int ObjectId { get; set; }

        ///<summary>
        /// Group ID
        ///</summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }
        [JsonProperty("type")]
        public UtilsDomainResolvedType Type { get; set; }
    }
}