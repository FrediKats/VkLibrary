using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Base;
using VkLibrary.Core.Types.Wall;

namespace VkLibrary.Core.Types.Notifications
{
    public class Feedback
    {
        /// <summary>
        /// Wall owner's ID
        /// </summary>
        [JsonProperty("to_id")]
        public int? ToId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<WallpostAttachment> Attachments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public LikesInfo Likes { get; set; }

        /// <summary>
        /// Item ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Reply author's ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("geo")]
        public Geo Geo { get; set; }

        /// <summary>
        /// Reply text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}