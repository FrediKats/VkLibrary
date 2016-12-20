using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class Link
    {
        /// <summary>
        /// Link caption
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// URL of the page with article preview
        /// </summary>
        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("application")]
        public VkLib.Types.Base.LinkApplication Application { get; set; }

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

        /// <summary>
        /// Information whether the link is external
        /// </summary>
        [JsonProperty("is_external")]
        public int? IsExternal { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("product")]
        public VkLib.Types.Base.LinkProduct Product { get; set; }

        /// <summary>
        /// Link description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("button")]
        public VkLib.Types.Base.LinkButton Button { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo")]
        public VkLib.Types.Photos.Photo Photo { get; set; }

        /// <summary>
        /// String ID of the page with article preview
        /// </summary>
        [JsonProperty("preview_page")]
        public string PreviewPage { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("rating")]
        public VkLib.Types.Base.LinkRating Rating { get; set; }

    }
}
