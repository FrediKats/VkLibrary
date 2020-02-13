using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseLinkButton
    {
        ///<summary>
        /// Button action
        ///</summary>
        [JsonProperty("action")]
        public BaseLinkButtonAction Action { get; set; }

        ///<summary>
        /// Button title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}