using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BaseLinkApplication
    {
        ///<summary>
        /// Application Id
        ///</summary>
        [JsonProperty("app_id")]
        public double AppId { get; set; }
        [JsonProperty("store")]
        public BaseLinkApplicationStore Store { get; set; }
    }
}