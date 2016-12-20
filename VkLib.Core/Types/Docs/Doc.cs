using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Docs 
{
    public class Doc
    {
        /// <summary>
        /// Access key for the document
        /// </summary>
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        /// <summary>
        /// File extension
        /// </summary>
        [JsonProperty("ext")]
        public string Ext_ { get; set; }

        /// <summary>
        /// Document ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// Date when file has been uploaded in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date_ { get; set; }

        /// <summary>
        /// Document owner ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// File size in bites
        /// </summary>
        [JsonProperty("size")]
        public int? Size_ { get; set; }

        /// <summary>
        /// File URL
        /// </summary>
        [JsonProperty("url")]
        public string Url_ { get; set; }

        /// <summary>
        /// Document type
        /// </summary>
        [JsonProperty("type")]
        public int? Type_ { get; set; }

        /// <summary>
        /// Document title
        /// </summary>
        [JsonProperty("title")]
        public string Title_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("preview")]
        public VkLib.Types.Docs.DocPreview Preview_ { get; set; }

    }
}
