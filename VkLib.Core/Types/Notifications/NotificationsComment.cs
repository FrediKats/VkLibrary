using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Notifications 
{
    public class NotificationsComment
    {
        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Comment ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Author ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("topic")]
        public VkLib.Types.Board.Topic Topic { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo")]
        public VkLib.Types.Photos.Photo Photo { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("video")]
        public VkLib.Types.Video.Video Video { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post")]
        public VkLib.Types.Wall.Wallpost Post { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

    }
}
