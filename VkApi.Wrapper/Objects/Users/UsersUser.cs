using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class UsersUser
    {
        ///<summary>
        /// User sex
        ///</summary>
        [JsonProperty("sex")]
        public BaseSex Sex { get; set; }

        ///<summary>
        /// Domain name of the user's page
        ///</summary>
        [JsonProperty("screen_name")]
        public String ScreenName { get; set; }

        ///<summary>
        /// URL of square photo of the user with 50 pixels in width
        ///</summary>
        [JsonProperty("photo_50")]
        public String Photo50 { get; set; }

        ///<summary>
        /// URL of square photo of the user with 100 pixels in width
        ///</summary>
        [JsonProperty("photo_100")]
        public String Photo100 { get; set; }

        ///<summary>
        /// Information whether the user is online
        ///</summary>
        [JsonProperty("online")]
        public int Online { get; set; }

        ///<summary>
        /// Information whether the user is online in mobile site or application
        ///</summary>
        [JsonProperty("online_mobile")]
        public int OnlineMobile { get; set; }

        ///<summary>
        /// Application ID
        ///</summary>
        [JsonProperty("online_app")]
        public int OnlineApp { get; set; }

        ///<summary>
        /// Information whether the user is verified
        ///</summary>
        [JsonProperty("verified")]
        public int Verified { get; set; }

        ///<summary>
        /// Information whether the user has a "fire" pictogram.
        ///</summary>
        [JsonProperty("trending")]
        public int Trending { get; set; }
        [JsonProperty("friend_status")]
        public FriendsFriendStatusStatus FriendStatus { get; set; }
        [JsonProperty("mutual")]
        public FriendsRequestsMutual Mutual { get; set; }
    }
}