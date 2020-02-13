using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseLinkButtonAction
    {
        [JsonProperty("type")]
        public BaseLinkButtonActionType Type { get; set; }

        ///<summary>
        /// Action URL
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}