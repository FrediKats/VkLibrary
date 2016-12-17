using System;
using Newtonsoft.Json;

namespace VkLib.Types.Messages 
{
    public class ChatPushSettings
    {
        /// <summary>
        /// Information whether the sound is on
        /// </summary>
        [JsonProperty("sound")]
        public BoolInt Sound { get; set; }

        /// <summary>
        /// Time until that notifications are disabled
        /// </summary>
        [JsonProperty("disabled_until")]
        public int? DisabledUntil { get; set; }

    }
}
