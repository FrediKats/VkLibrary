using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class UtilsLinkChecked
    {
        ///<summary>
        /// Link URL
        ///</summary>
        [JsonProperty("link")]
        public String Link { get; set; }
        [JsonProperty("status")]
        public UtilsLinkCheckedStatus Status { get; set; }
    }
}