using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BaseObjectCount
    {
        ///<summary>
        /// Items count
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}