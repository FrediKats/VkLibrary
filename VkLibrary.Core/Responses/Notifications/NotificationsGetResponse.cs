using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Apps;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Photos;
using VkApi.Wrapper.Types.Users;
using VkApi.Wrapper.Types.Video;

namespace VkApi.Wrapper.Responses.Notifications
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