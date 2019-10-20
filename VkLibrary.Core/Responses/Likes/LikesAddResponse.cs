using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class LikesAddResponse
    {
        ///<summary>
        /// Total likes number
        ///</summary>
        [JsonProperty("likes")]
        public int Likes { get; set; }
    }
}