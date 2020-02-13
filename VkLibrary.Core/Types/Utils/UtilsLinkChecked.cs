using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Utils
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