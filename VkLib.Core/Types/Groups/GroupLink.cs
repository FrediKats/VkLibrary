using System;
using Newtonsoft.Json;

namespace VkLib.Types.Groups 
{
    public class GroupLink
    {
        /// <summary>
        /// Link ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Link URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Link description
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// Information whether the image on processing
        /// </summary>
        [JsonProperty("image_processing")]
        public BoolInt ImageProcessing { get; set; }

        /// <summary>
        /// Information whether the title can be edited
        /// </summary>
        [JsonProperty("edit_title")]
        public BoolInt EditTitle { get; set; }

    }
}
