using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class DocsDoc
    {
        ///<summary>
        /// Access key for the document
        ///</summary>
        [JsonProperty("access_key")]
        public String AccessKey { get; set; }

        ///<summary>
        /// Date when file has been uploaded in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// File extension
        ///</summary>
        [JsonProperty("ext")]
        public String Ext { get; set; }

        ///<summary>
        /// Document ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("is_licensed")]
        public int IsLicensed { get; set; }

        ///<summary>
        /// Document owner ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("preview")]
        public DocsDocPreview Preview { get; set; }

        ///<summary>
        /// File size in bites
        ///</summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        ///<summary>
        /// Document title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Document type
        ///</summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        ///<summary>
        /// File URL
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}