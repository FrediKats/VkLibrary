using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class LeadsStart
    {
        ///<summary>
        /// Information whether test mode is enabled
        ///</summary>
        [JsonProperty("test_mode")]
        public int TestMode { get; set; }

        ///<summary>
        /// Session data
        ///</summary>
        [JsonProperty("vk_sid")]
        public String VkSid { get; set; }
    }
}