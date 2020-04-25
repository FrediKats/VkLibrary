using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NotificationsFeedback
    {
        [JsonProperty("attachments")]
        public WallWallpostAttachment[] Attachments { get; set; }

        ///<summary>
        /// Reply author's ID
        ///</summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }
        [JsonProperty("geo")]
        public BaseGeo Geo { get; set; }

        ///<summary>
        /// Item ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("likes")]
        public BaseLikesInfo Likes { get; set; }

        ///<summary>
        /// Reply text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// Wall owner's ID
        ///</summary>
        [JsonProperty("to_id")]
        public int ToId { get; set; }
    }
}