using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class PhotosCommentXtrPid
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
        [JsonProperty("likes")]
        public BaseLikesInfo Likes { get; set; }

        ///<summary>
        /// Photo ID
        ///</summary>
        [JsonProperty("pid")]
        public int Pid { get; set; }

        ///<summary>
        /// Replied comment ID
        ///</summary>
        [JsonProperty("reply_to_comment")]
        public int ReplyToComment { get; set; }

        ///<summary>
        /// Replied user ID
        ///</summary>
        [JsonProperty("reply_to_user")]
        public int ReplyToUser { get; set; }

        ///<summary>
        /// Comment text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }
        [JsonProperty("parents_stack")]
        public int[] ParentsStack { get; set; }
        [JsonProperty("thread")]
        public CommentThread Thread { get; set; }
    }
}