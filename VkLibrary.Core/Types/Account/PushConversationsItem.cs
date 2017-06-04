using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Account
{
    public class PushConversationsItem
    {
        /// <summary>
        /// Information whether the sound are enabled
        /// </summary>
        [JsonProperty("sound")]
        public int? Sound { get; set; }

        /// <summary>
        /// Peer ID
        /// </summary>
        [JsonProperty("peer_id")]
        public int? PeerId { get; set; }

        /// <summary>
        /// Time until that notifications are disabled in seconds
        /// </summary>
        [JsonProperty("disabled_until")]
        public int? DisabledUntil { get; set; }
    }
}