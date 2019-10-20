using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class LikesIsLikedResponse
    {
        ///<summary>
        /// Information whether user liked the object
        ///</summary>
        [JsonProperty("liked")]
        public int Liked { get; set; }

        ///<summary>
        /// Information whether user reposted the object
        ///</summary>
        [JsonProperty("copied")]
        public int Copied { get; set; }
    }
}