using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class GiftsGift
    {
        ///<summary>
        /// Date when gist has been sent in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Gift sender ID
        ///</summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }
        [JsonProperty("gift")]
        public GiftsLayout Gift { get; set; }

        ///<summary>
        /// Hash
        ///</summary>
        [JsonProperty("gift_hash")]
        public String GiftHash { get; set; }

        ///<summary>
        /// Gift ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Comment text
        ///</summary>
        [JsonProperty("message")]
        public String Message { get; set; }
        [JsonProperty("privacy")]
        public GiftsGiftPrivacy Privacy { get; set; }
    }
}