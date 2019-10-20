using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class NotificationsGetResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public object[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUser[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroup[] Groups { get; set; }

        ///<summary>
        /// Time when user has been checked notifications last time
        ///</summary>
        [JsonProperty("last_viewed")]
        public int LastViewed { get; set; }
        [JsonProperty("photos")]
        public PhotosPhoto[] Photos { get; set; }
        [JsonProperty("videos")]
        public VideoVideo[] Videos { get; set; }
        [JsonProperty("apps")]
        public AppsApp[] Apps { get; set; }
        [JsonProperty("next_from")]
        public String NextFrom { get; set; }
        [JsonProperty("ttl")]
        public int Ttl { get; set; }
    }
}