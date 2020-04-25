using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class SecureLevel
    {
        ///<summary>
        /// Level
        ///</summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("uid")]
        public int Uid { get; set; }
    }
}