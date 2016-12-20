using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Notifications 
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
        public IEnumerable<VkLib.Types.Wall.WallpostAttachment> Attachments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Base.LikesInfo Likes { get; set; }

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
        public VkLib.Types.Base.Geo Geo { get; set; }

        /// <summary>
        /// Reply text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

    }
}
