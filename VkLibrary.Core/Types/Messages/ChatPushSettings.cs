using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Messages
{
    public class ChatPushSettings
    {
        /// <summary>
        /// Information whether the sound is on
        /// </summary>
        [JsonProperty("sound")]
        public int? Sound { get; set; }

        /// <summary>
        /// Time until that notifications are disabled
        /// </summary>
        [JsonProperty("disabled_until")]
        public int? DisabledUntil { get; set; }
    }
}