using System;
using Newtonsoft.Json;

namespace VkLib.Types.Account 
{
    public class PushParams
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("app_request")]
        public IEnumerable<OnoffOptions> AppRequest { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sdk_open")]
        public IEnumerable<OnoffOptions> SdkOpen { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("mention")]
        public IEnumerable<string> Mention { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("friend_accepted")]
        public IEnumerable<OnoffOptions> FriendAccepted { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reply")]
        public IEnumerable<OnoffOptions> Reply { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("group_invite")]
        public IEnumerable<OnoffOptions> GroupInvite { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("group_accepted")]
        public IEnumerable<OnoffOptions> GroupAccepted { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("chat")]
        public IEnumerable<string> Chat { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("friend")]
        public IEnumerable<OnoffOptions> Friend { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("new_post")]
        public IEnumerable<OnoffOptions> NewPost { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("comment")]
        public IEnumerable<string> Comment { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("event_soon")]
        public IEnumerable<OnoffOptions> EventSoon { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("repost")]
        public IEnumerable<string> Repost { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("friend_found")]
        public IEnumerable<OnoffOptions> FriendFound { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("wall_publish")]
        public IEnumerable<OnoffOptions> WallPublish { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("birthday")]
        public IEnumerable<OnoffOptions> Birthday { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("like")]
        public IEnumerable<string> Like { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photos_tag")]
        public IEnumerable<string> PhotosTag { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("wall_post")]
        public IEnumerable<OnoffOptions> WallPost { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("msg")]
        public IEnumerable<string> Msg { get; set; }

    }
}
