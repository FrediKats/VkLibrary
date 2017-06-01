using Newtonsoft.Json;
using VkLib.Types.Audio;
using VkLib.Types.Base;
using VkLib.Types.Docs;
using VkLib.Types.Photos;

namespace VkLib.Types.Messages
{
    public class AttachmentsHistory
    {
        /// <summary>
        ///     Attachments type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("audio")]
        public AudioFull Audio { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("photo")]
        public Photo Photo { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("video")]
        public Video.Video Video { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("link")]
        public Link Link { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("doc")]
        public Doc Doc { get; set; }
    }
}