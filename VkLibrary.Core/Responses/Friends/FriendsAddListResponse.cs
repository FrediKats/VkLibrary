using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class FriendsAddListResponse
    {
        ///<summary>
        /// List ID
        ///</summary>
        [JsonProperty("list_id")]
        public int ListId { get; set; }
    }
}