using System;
using Newtonsoft.Json;

namespace VkLib.Types.Wall 
{
    public class Wallpost
    {
        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Post signer ID
        /// </summary>
        [JsonProperty("signer_id")]
        public int? SignerId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("geo")]
        public Geo Geo { get; set; }

        /// <summary>
        /// Date of publishing in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post_type")]
        public PostType PostType { get; set; }

        /// <summary>
        /// Post author ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId { get; set; }

        /// <summary>
        /// Post text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<WallpostAttachment> Attachments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post_source")]
        public PostSource PostSource { get; set; }

        /// <summary>
        /// Wall owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

    }
}
