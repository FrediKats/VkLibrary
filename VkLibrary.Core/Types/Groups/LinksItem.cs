using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Groups
{
    /// <summary>
    /// API LinksItem object.
    /// </summary>
    public class LinksItem
    {
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
        /// Link title
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Information whether the link title can be edited
        /// </summary>
        [JsonProperty("edit_title")]
        public int? EditTitle { get; set; }

        /// <summary>
        /// URL of square image of the link with 50 pixels in width
        /// </summary>
        [JsonProperty("photo_50")]
        public string Photo50 { get; set; }

        /// <summary>
        /// Link URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// URL of square image of the link with 100 pixels in width
        /// </summary>
        [JsonProperty("photo_100")]
        public string Photo100 { get; set; }
    }
}