using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Gifts 
{
    public class Gift
    {
        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("message")]
        public string Message_ { get; set; }

        /// <summary>
        /// Gift privacy
        /// </summary>
        [JsonProperty("privacy")]
        public int? Privacy_ { get; set; }

        /// <summary>
        /// Gift ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("gift")]
        public VkLib.Types.Gifts.Layout Gift_ { get; set; }

        /// <summary>
        /// Date when gist has been sent in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date_ { get; set; }

        /// <summary>
        /// Gift sender ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId { get; set; }

        /// <summary>
        /// Hash
        /// </summary>
        [JsonProperty("gift_hash")]
        public string GiftHash { get; set; }

    }
}
