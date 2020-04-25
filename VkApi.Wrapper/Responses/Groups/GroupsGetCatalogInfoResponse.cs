using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class GroupsGetCatalogInfoResponse
    {
        ///<summary>
        /// Information whether catalog is enabled for current user
        ///</summary>
        [JsonProperty("enabled")]
        public int Enabled { get; set; }
        [JsonProperty("categories")]
        public GroupsGroupCategory[] Categories { get; set; }
    }
}