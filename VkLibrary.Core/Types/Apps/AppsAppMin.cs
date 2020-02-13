using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Apps
{
    public class AppsAppMin
    {
        [JsonProperty("type")]
        public AppsAppType Type { get; set; }

        ///<summary>
        /// Application ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Application title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Application author's ID
        ///</summary>
        [JsonProperty("author_id")]
        public int AuthorId { get; set; }

        ///<summary>
        /// URL of the app icon with 139 px in width
        ///</summary>
        [JsonProperty("icon_139")]
        public String Icon139 { get; set; }

        ///<summary>
        /// URL of the app icon with 150 px in width
        ///</summary>
        [JsonProperty("icon_150")]
        public String Icon150 { get; set; }

        ///<summary>
        /// URL of the app icon with 278 px in width
        ///</summary>
        [JsonProperty("icon_278")]
        public String Icon278 { get; set; }

        ///<summary>
        /// URL of the app icon with 75 px in width
        ///</summary>
        [JsonProperty("icon_75")]
        public String Icon75 { get; set; }
    }
}