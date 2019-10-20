using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class WallPostAdsStealthResponse
    {
        ///<summary>
        /// Created post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}