using Newtonsoft.Json;
using VkLibrary.Core.Types.Audio;

namespace VkLibrary.Core.Types.Status
{
    /// <summary>
    /// API Status object.
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("audio")]
        public AudioFull Audio { get; set; }

        /// <summary>
        /// Status text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}