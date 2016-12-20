using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Wall 
{
    public class WallpostFull : VkLib.Types.Wall.Wallpost
    {
        /// <summary>
        /// Information whether current user can edit the post
        /// </summary>
        [JsonProperty("can_edit")]
        public int? CanEdit_ { get; set; }

        /// <summary>
        /// Post creator ID (if post still can be edited)
        /// </summary>
        [JsonProperty("created_by")]
        public int? CreatedBy_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Base.LikesInfo Likes { get; set; }

        /// <summary>
        /// Information whether the post is pinned
        /// </summary>
        [JsonProperty("is_pinned")]
        public int? IsPinned_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("comments")]
        public VkLib.Types.Base.CommentsInfo Comments { get; set; }

        /// <summary>
        /// Information whether current user can pin the post
        /// </summary>
        [JsonProperty("can_pin")]
        public int? CanPin_ { get; set; }

        /// <summary>
        /// Information whether current user can delete the post
        /// </summary>
        [JsonProperty("can_delete")]
        public int? CanDelete_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("copy_history")]
        public IEnumerable<VkLib.Types.Wall.Wallpost> CopyHistory_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reposts")]
        public VkLib.Types.Base.RepostsInfo Reposts { get; set; }

    }
}
