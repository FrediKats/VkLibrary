using Newtonsoft.Json;

namespace VkLib.Types.Account
{
    public class PushSettings
    {
        /// <summary>
        ///     Time until that notifications are disabled in Unixtime
        /// </summary>
        [JsonProperty("disabled_until")]
        public int? DisabledUntil { get; set; }

        /// <summary>
        ///     Information whether notifications are disabled
        /// </summary>
        [JsonProperty("disabled")]
        public int? Disabled { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("settings")]
        public PushParams Settings { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("conversations")]
        public PushConversations Conversations { get; set; }
    }
}