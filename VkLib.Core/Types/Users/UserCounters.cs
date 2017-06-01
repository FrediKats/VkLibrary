using Newtonsoft.Json;

namespace VkLib.Types.Users
{
    public class UserCounters
    {
        /// <summary>
        ///     Online friends number
        /// </summary>
        [JsonProperty("online_friends")]
        public int? OnlineFriends { get; set; }

        /// <summary>
        ///     Albums number
        /// </summary>
        [JsonProperty("albums")]
        public int? Albums { get; set; }

        /// <summary>
        ///     Number of photos with user
        /// </summary>
        [JsonProperty("user_photos")]
        public int? UserPhotos { get; set; }

        /// <summary>
        ///     Subscriptions number
        /// </summary>
        [JsonProperty("subscriptions")]
        public int? Subscriptions { get; set; }

        /// <summary>
        ///     Gifts number
        /// </summary>
        [JsonProperty("gifts")]
        public int? Gifts { get; set; }

        /// <summary>
        ///     Number of videos with user
        /// </summary>
        [JsonProperty("user_videos")]
        public int? UserVideos { get; set; }

        /// <summary>
        ///     Followers number
        /// </summary>
        [JsonProperty("followers")]
        public int? Followers { get; set; }

        /// <summary>
        ///     Public pages number
        /// </summary>
        [JsonProperty("pages")]
        public int? Pages { get; set; }

        /// <summary>
        ///     Videos number
        /// </summary>
        [JsonProperty("videos")]
        public int? Videos { get; set; }

        /// <summary>
        ///     Photos number
        /// </summary>
        [JsonProperty("photos")]
        public int? Photos { get; set; }

        /// <summary>
        ///     Audios number
        /// </summary>
        [JsonProperty("audios")]
        public int? Audios { get; set; }

        /// <summary>
        ///     Friends number
        /// </summary>
        [JsonProperty("friends")]
        public int? Friends { get; set; }

        /// <summary>
        ///     Notes number
        /// </summary>
        [JsonProperty("notes")]
        public int? Notes { get; set; }

        /// <summary>
        ///     Communities number
        /// </summary>
        [JsonProperty("groups")]
        public int? Groups { get; set; }
    }
}