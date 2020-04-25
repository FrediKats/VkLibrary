using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BoardTopicComment
    {
        [JsonProperty("attachments")]
        public WallCommentAttachment[] Attachments { get; set; }

        ///<summary>
        /// Date when the comment has been added in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Author ID
        ///</summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        ///<summary>
        /// Comment ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Real position of the comment
        ///</summary>
        [JsonProperty("real_offset")]
        public int RealOffset { get; set; }

        ///<summary>
        /// Comment text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// Information whether current user can edit the comment
        ///</summary>
        [JsonProperty("can_edit")]
        public int CanEdit { get; set; }
        [JsonProperty("likes")]
        public BaseLikesInfo Likes { get; set; }
    }
}