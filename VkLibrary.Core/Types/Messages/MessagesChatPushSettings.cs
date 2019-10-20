using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class MessagesChatPushSettings
    {
        ///<summary>
        /// Time until that notifications are disabled
        ///</summary>
        [JsonProperty("disabled_until")]
        public int DisabledUntil { get; set; }

        ///<summary>
        /// Information whether the sound is on
        ///</summary>
        [JsonProperty("sound")]
        public int Sound { get; set; }
    }
}