using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsAccesses
    {
        ///<summary>
        /// Client ID
        ///</summary>
        [JsonProperty("client_id")]
        public String ClientId { get; set; }
        [JsonProperty("role")]
        public AdsAccessRole Role { get; set; }
    }
}