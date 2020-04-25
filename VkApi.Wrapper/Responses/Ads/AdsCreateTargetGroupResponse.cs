using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
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