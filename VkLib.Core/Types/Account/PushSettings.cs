using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Account 
{
    public class PushSettings
    {
        /// <summary>
        /// Time until that notifications are disabled in Unixtime
        /// </summary>
        [JsonProperty("disabled_until")]
        public int? DisabledUntil { get; set; }

        /// <summary>
        /// Information whether notifications are disabled
        /// </summary>
        [JsonProperty("disabled")]
        public int? Disabled { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("settings")]
        public VkLib.Types.Account.PushParams Settings { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("conversations")]
        public VkLib.Types.Account.PushConversations Conversations { get; set; }

    }
}
