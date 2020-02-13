using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsRejectReason
    {
        ///<summary>
        /// Comment text
        ///</summary>
        [JsonProperty("comment")]
        public String Comment { get; set; }
        [JsonProperty("rules")]
        public AdsRules[] Rules { get; set; }
    }
}