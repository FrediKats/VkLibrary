using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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
        [JsonProperty("author_owner_id")]
        public int AuthorOwnerId { get; set; }

        ///<summary>
        /// Is application installed
        ///</summary>
        [JsonProperty("is_installed")]
        public Boolean IsInstalled { get; set; }

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
        /// URL of the app icon with 576 px in width
        ///</summary>
        [JsonProperty("icon_576")]
        public String Icon576 { get; set; }

        ///<summary>
        /// URL of the app icon with 75 px in width
        ///</summary>
        [JsonProperty("icon_75")]
        public String Icon75 { get; set; }
    }
}