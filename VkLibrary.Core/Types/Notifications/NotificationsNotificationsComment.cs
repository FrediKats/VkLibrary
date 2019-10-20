using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class NotificationsNotificationsComment
    {
        ///<summary>
        /// Date when the comment has been added in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Comment ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Author ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("photo")]
        public PhotosPhoto Photo { get; set; }
        [JsonProperty("post")]
        public WallWallpost Post { get; set; }

        ///<summary>
        /// Comment text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }
        [JsonProperty("topic")]
        public BoardTopic Topic { get; set; }
        [JsonProperty("video")]
        public VideoVideo Video { get; set; }
    }
}