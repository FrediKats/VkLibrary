using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Ads
{
    public class AdsCreateTargetGroupResponse
    {
        ///<summary>
        /// Group ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Pixel code
        ///</summary>
        [JsonProperty("pixel")]
        public String Pixel { get; set; }
    }
}