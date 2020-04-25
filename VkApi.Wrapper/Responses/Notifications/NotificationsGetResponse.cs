using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class NotificationsGetResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        //TODO: fix
        //[JsonProperty("items")]
        //public NotificationsNotificationItem[] Items { get; set; }
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