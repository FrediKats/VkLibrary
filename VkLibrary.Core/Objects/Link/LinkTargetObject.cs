using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class LinkTargetObject
    {
        ///<summary>
        /// Object type
        ///</summary>
        [JsonProperty("type")]
        public String Type { get; set; }

        ///<summary>
        /// Owner ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// Item ID
        ///</summary>
        [JsonProperty("item_id")]
        public int ItemId { get; set; }
    }
}