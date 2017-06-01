using Newtonsoft.Json;
using VkLib.Types.Audio;

namespace VkLib.Types.Users
{
    public class UserBroadcast : UserMin
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("status_audio")]
        public AudioFull StatusAudio { get; set; }
    }
}