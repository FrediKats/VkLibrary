using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class LikesDeleteResponse
    {
        ///<summary>
        /// Total likes number
        ///</summary>
        [JsonProperty("likes")]
        public int Likes { get; set; }
    }
}