using Newtonsoft.Json;
using VkLib.Types.Audio;

namespace VkLib.Types.Status
{
    public class Status
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("audio")]
        public AudioFull Audio { get; set; }

        /// <summary>
        ///     Status text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}