using System;
using Newtonsoft.Json;

namespace VkLib.Types.Fave 
{
    public class FavesLink
    {
        /// <summary>
        /// Link ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// URL of the preview image with 100 px in width
        /// </summary>
        [JsonProperty("photo_100")]
        public string Photo100 { get; set; }

        /// <summary>
        /// URL of the preview image with 50 px in width
        /// </summary>
        [JsonProperty("photo_50")]
        public string Photo50 { get; set; }

        /// <summary>
        /// URL of the preview image with 200 px in width
        /// </summary>
        [JsonProperty("photo_200")]
        public string Photo200 { get; set; }

        /// <summary>
        /// Link description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Link URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Link title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
