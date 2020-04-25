using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class GroupsGetMembersFieldsResponse
    {
        ///<summary>
        /// Total members number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public GroupsUserXtrRole[] Items { get; set; }
    }
}