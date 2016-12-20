using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Users 
{
    public class UserBroadcast : VkLib.Types.Users.UserMin
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("status_audio")]
        public VkLib.Types.Audio.AudioFull StatusAudio { get; set; }

    }
}
