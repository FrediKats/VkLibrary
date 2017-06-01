using Newtonsoft.Json;

namespace VkLib.Types.Audio
{
    public class AudioAlbum
    {
        /// <summary>
        ///     Album ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     Album owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        ///     Album title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}