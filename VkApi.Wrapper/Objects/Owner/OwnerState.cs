using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class OwnerState
    {
        [JsonProperty("state")]
        public int State { get; set; }

        ///<summary>
        /// wiki text to describe user state
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }
    }
}