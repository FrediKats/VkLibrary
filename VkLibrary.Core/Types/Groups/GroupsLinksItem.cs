using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class GroupsLinksItem
    {
        ///<summary>
        /// Link description
        ///</summary>
        [JsonProperty("desc")]
        public String Desc { get; set; }

        ///<summary>
        /// Information whether the link title can be edited
        ///</summary>
        [JsonProperty("edit_title")]
        public int EditTitle { get; set; }

        ///<summary>
        /// Link ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Link title
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// URL of square image of the link with 100 pixels in width
        ///</summary>
        [JsonProperty("photo_100")]
        public String Photo100 { get; set; }

        ///<summary>
        /// URL of square image of the link with 50 pixels in width
        ///</summary>
        [JsonProperty("photo_50")]
        public String Photo50 { get; set; }

        ///<summary>
        /// Link URL
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}