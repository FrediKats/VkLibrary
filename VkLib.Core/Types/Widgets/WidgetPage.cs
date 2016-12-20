using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Widgets 
{
    public class WidgetPage
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("comments")]
        public VkLib.Types.Base.ObjectCount Comments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Base.ObjectCount Likes { get; set; }

        /// <summary>
        /// Page ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Page description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Date when widgets on the page has been initialized firstly in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// page_id parameter value
        /// </summary>
        [JsonProperty("page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// URL of the preview image
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// Page absolute URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Page title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
