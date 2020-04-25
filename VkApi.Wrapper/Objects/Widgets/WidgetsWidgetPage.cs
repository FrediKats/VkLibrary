using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class WidgetsWidgetPage
    {
        [JsonProperty("comments")]
        public BaseObjectCount Comments { get; set; }

        ///<summary>
        /// Date when widgets on the page has been initialized firstly in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Page description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// Page ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("likes")]
        public BaseObjectCount Likes { get; set; }

        ///<summary>
        /// page_id parameter value
        ///</summary>
        [JsonProperty("page_id")]
        public String PageId { get; set; }

        ///<summary>
        /// URL of the preview image
        ///</summary>
        [JsonProperty("photo")]
        public String Photo { get; set; }

        ///<summary>
        /// Page title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Page absolute URL
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}