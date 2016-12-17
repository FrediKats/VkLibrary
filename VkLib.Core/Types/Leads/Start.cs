using System;
using Newtonsoft.Json;

namespace VkLib.Types.Leads 
{
    public class Start
    {
        /// <summary>
        /// Session data
        /// </summary>
        [JsonProperty("vk_sid")]
        public string VkSid { get; set; }

        /// <summary>
        /// Information whether test mode is enabled
        /// </summary>
        [JsonProperty("test_mode")]
        public BoolInt TestMode { get; set; }

    }
}
