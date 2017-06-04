using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Docs
{
    public class Doc
    {
        /// <summary>
        /// File extension
        /// </summary>
        [JsonProperty("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// Date when file has been uploaded in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public double? Date { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("preview")]
        public DocPreview Preview { get; set; }

        /// <summary>
        /// Document ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Document owner ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Access key for the document
        /// </summary>
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Document type
        /// </summary>
        [JsonProperty("type")]
        public int? Type { get; set; }

        /// <summary>
        /// File URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Document title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// File size in bites
        /// </summary>
        [JsonProperty("size")]
        public long? Size { get; set; }
    }
}