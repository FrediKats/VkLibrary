using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AccountPushSettings
    {
        ///<summary>
        /// Information whether notifications are disabled
        ///</summary>
        [JsonProperty("disabled")]
        public int Disabled { get; set; }

        ///<summary>
        /// Time until that notifications are disabled in Unixtime
        ///</summary>
        [JsonProperty("disabled_until")]
        public int DisabledUntil { get; set; }
        [JsonProperty("settings")]
        public AccountPushParams Settings { get; set; }
        [JsonProperty("conversations")]
        public AccountPushConversations Conversations { get; set; }
    }
}