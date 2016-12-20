using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Account 
{
    public class PushParams
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("birthday")]
        public IEnumerable<string> Birthday { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("comment")]
        public IEnumerable<string> Comment { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reply")]
        public IEnumerable<string> Reply { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photos_tag")]
        public IEnumerable<string> PhotosTag_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("friend")]
        public IEnumerable<string> Friend { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("msg")]
        public IEnumerable<string> Msg { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("friend_found")]
        public IEnumerable<string> FriendFound_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("app_request")]
        public IEnumerable<string> AppRequest_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("chat")]
        public IEnumerable<string> Chat { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("friend_accepted")]
        public IEnumerable<string> FriendAccepted_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("wall_post")]
        public IEnumerable<string> WallPost_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("wall_publish")]
        public IEnumerable<string> WallPublish_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("like")]
        public IEnumerable<string> Like { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("group_accepted")]
        public IEnumerable<string> GroupAccepted_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("new_post")]
        public IEnumerable<string> NewPost_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("mention")]
        public IEnumerable<string> Mention { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sdk_open")]
        public IEnumerable<string> SdkOpen_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("event_soon")]
        public IEnumerable<string> EventSoon_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("group_invite")]
        public IEnumerable<string> GroupInvite_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("repost")]
        public IEnumerable<string> Repost { get; set; }

    }
}
