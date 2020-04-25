using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class UsersUserConnections
    {
        ///<summary>
        /// User's Skype nickname
        ///</summary>
        [JsonProperty("skype")]
        public String Skype { get; set; }

        ///<summary>
        /// User's Facebook account
        ///</summary>
        [JsonProperty("facebook")]
        public String Facebook { get; set; }

        ///<summary>
        /// User's Facebook name
        ///</summary>
        [JsonProperty("facebook_name")]
        public String FacebookName { get; set; }

        ///<summary>
        /// User's Twitter account
        ///</summary>
        [JsonProperty("twitter")]
        public String Twitter { get; set; }

        ///<summary>
        /// User's Livejournal account
        ///</summary>
        [JsonProperty("livejournal")]
        public String Livejournal { get; set; }

        ///<summary>
        /// User's Instagram account
        ///</summary>
        [JsonProperty("instagram")]
        public String Instagram { get; set; }
    }
}