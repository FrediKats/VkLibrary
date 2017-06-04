using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Groups
{
    public class GroupLink
    {
        /// <summary>
        /// Link URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Information whether the title can be edited
        /// </summary>
        [JsonProperty("edit_title")]
        public int? EditTitle { get; set; }

        /// <summary>
        /// Link ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Link description
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// Information whether the image on processing
        /// </summary>
        [JsonProperty("image_processing")]
        public int? ImageProcessing { get; set; }
    }
}