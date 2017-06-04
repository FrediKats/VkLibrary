using Newtonsoft.Json;
using VkLibrary.Core.Types.Audio;

namespace VkLibrary.Core.Types.Users
{
    public class UserBroadcast : UserMin
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("status_audio")]
        public AudioFull StatusAudio { get; set; }
    }
}