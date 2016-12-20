using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Account 
{
    public class Info
    {
        /// <summary>
        /// Information whether only owners posts should be shown
        /// </summary>
        [JsonProperty("own_posts_default")]
        public int? OwnPostsDefault { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        [JsonProperty("country")]
        public string Country_ { get; set; }

        /// <summary>
        /// Language ID
        /// </summary>
        [JsonProperty("lang")]
        public int? Lang_ { get; set; }

        /// <summary>
        /// Information whether user has been processed intro 
        /// </summary>
        [JsonProperty("intro")]
        public int? Intro_ { get; set; }

        /// <summary>
        /// Information whether wall comments should be hidden
        /// </summary>
        [JsonProperty("no_wall_replies")]
        public int? NoWallReplies { get; set; }

        /// <summary>
        /// Information whether HTTPS-only is enabled
        /// </summary>
        [JsonProperty("https_required")]
        public int? HttpsRequired { get; set; }

        /// <summary>
        /// Two factor authentication is enabled
        /// </summary>
        [JsonProperty("2fa_required")]
        public int? _2faRequired { get; set; }

    }
}
