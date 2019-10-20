using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class AccountPushConversationsItem
    {
        ///<summary>
        /// Time until that notifications are disabled in seconds
        ///</summary>
        [JsonProperty("disabled_until")]
        public int DisabledUntil { get; set; }

        ///<summary>
        /// Peer ID
        ///</summary>
        [JsonProperty("peer_id")]
        public int PeerId { get; set; }

        ///<summary>
        /// Information whether the sound are enabled
        ///</summary>
        [JsonProperty("sound")]
        public int Sound { get; set; }
    }
}