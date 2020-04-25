using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AccountAccountCounters
    {
        ///<summary>
        /// New app requests number
        ///</summary>
        [JsonProperty("app_requests")]
        public int AppRequests { get; set; }

        ///<summary>
        /// New events number
        ///</summary>
        [JsonProperty("events")]
        public int Events { get; set; }

        ///<summary>
        /// New faves number
        ///</summary>
        [JsonProperty("faves")]
        public int Faves { get; set; }

        ///<summary>
        /// New friends requests number
        ///</summary>
        [JsonProperty("friends")]
        public int Friends { get; set; }

        ///<summary>
        /// New friends suggestions number
        ///</summary>
        [JsonProperty("friends_suggestions")]
        public int FriendsSuggestions { get; set; }

        ///<summary>
        /// New friends recommendations number
        ///</summary>
        [JsonProperty("friends_recommendations")]
        public int FriendsRecommendations { get; set; }

        ///<summary>
        /// New gifts number
        ///</summary>
        [JsonProperty("gifts")]
        public int Gifts { get; set; }

        ///<summary>
        /// New groups number
        ///</summary>
        [JsonProperty("groups")]
        public int Groups { get; set; }
        [JsonProperty("menu_discover_badge")]
        public int MenuDiscoverBadge { get; set; }

        ///<summary>
        /// New messages number
        ///</summary>
        [JsonProperty("messages")]
        public int Messages { get; set; }

        ///<summary>
        /// New memories number
        ///</summary>
        [JsonProperty("memories")]
        public int Memories { get; set; }

        ///<summary>
        /// New notes number
        ///</summary>
        [JsonProperty("notes")]
        public int Notes { get; set; }

        ///<summary>
        /// New notifications number
        ///</summary>
        [JsonProperty("notifications")]
        public int Notifications { get; set; }

        ///<summary>
        /// New photo tags number
        ///</summary>
        [JsonProperty("photos")]
        public int Photos { get; set; }

        ///<summary>
        /// New sdk number
        ///</summary>
        [JsonProperty("sdk")]
        public int Sdk { get; set; }
    }
}