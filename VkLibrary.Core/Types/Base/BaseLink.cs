using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Photos;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseLink
    {
        [JsonProperty("application")]
        public BaseLinkApplication Application { get; set; }
        [JsonProperty("button")]
        public BaseLinkButton Button { get; set; }

        ///<summary>
        /// Link caption
        ///</summary>
        [JsonProperty("caption")]
        public String Caption { get; set; }

        ///<summary>
        /// Link description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// Link ID
        ///</summary>
        [JsonProperty("id")]
        public String Id { get; set; }
        [JsonProperty("is_favorite")]
        public Boolean IsFavorite { get; set; }
        [JsonProperty("photo")]
        public PhotosPhoto Photo { get; set; }

        ///<summary>
        /// String ID of the page with article preview
        ///</summary>
        [JsonProperty("preview_page")]
        public String PreviewPage { get; set; }

        ///<summary>
        /// URL of the page with article preview
        ///</summary>
        [JsonProperty("preview_url")]
        public String PreviewUrl { get; set; }
        [JsonProperty("product")]
        public BaseLinkProduct Product { get; set; }
        [JsonProperty("rating")]
        public BaseLinkRating Rating { get; set; }

        ///<summary>
        /// Link title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Link URL
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}