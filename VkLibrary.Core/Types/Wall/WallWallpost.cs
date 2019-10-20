using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class WallWallpost
    {
        ///<summary>
        /// Access key to private object
        ///</summary>
        [JsonProperty("access_key")]
        public String AccessKey { get; set; }
        [JsonProperty("attachments")]
        public WallWallpostAttachment[] Attachments { get; set; }

        ///<summary>
        /// Date of publishing in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Date of editing in Unixtime
        ///</summary>
        [JsonProperty("edited")]
        public int Edited { get; set; }

        ///<summary>
        /// Post author ID
        ///</summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }
        [JsonProperty("geo")]
        public WallGeo Geo { get; set; }

        ///<summary>
        /// Post ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Is post archived, only for post owners
        ///</summary>
        [JsonProperty("is_archived")]
        public Boolean IsArchived { get; set; }

        ///<summary>
        /// Information whether the post in favorites list
        ///</summary>
        [JsonProperty("is_favorite")]
        public Boolean IsFavorite { get; set; }

        ///<summary>
        /// Count of likes
        ///</summary>
        [JsonProperty("likes")]
        public BaseLikesInfo Likes { get; set; }

        ///<summary>
        /// Wall owner's ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("post_source")]
        public WallPostSource PostSource { get; set; }
        [JsonProperty("post_type")]
        public WallPostType PostType { get; set; }

        ///<summary>
        /// Count of views
        ///</summary>
        [JsonProperty("reposts")]
        public BaseRepostsInfo Reposts { get; set; }

        ///<summary>
        /// Post signer ID
        ///</summary>
        [JsonProperty("signer_id")]
        public int SignerId { get; set; }

        ///<summary>
        /// Post text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// Count of views
        ///</summary>
        [JsonProperty("views")]
        public WallViews Views { get; set; }
    }
}