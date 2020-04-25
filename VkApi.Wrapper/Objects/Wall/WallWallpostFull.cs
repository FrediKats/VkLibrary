using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class WallWallpostFull
    {
        [JsonProperty("copy_history")]
        public WallWallpost[] CopyHistory { get; set; }

        ///<summary>
        /// Information whether current user can edit the post
        ///</summary>
        [JsonProperty("can_edit")]
        public int CanEdit { get; set; }

        ///<summary>
        /// Post creator ID (if post still can be edited)
        ///</summary>
        [JsonProperty("created_by")]
        public int CreatedBy { get; set; }

        ///<summary>
        /// Information whether current user can delete the post
        ///</summary>
        [JsonProperty("can_delete")]
        public int CanDelete { get; set; }

        ///<summary>
        /// Information whether current user can pin the post
        ///</summary>
        [JsonProperty("can_pin")]
        public int CanPin { get; set; }

        ///<summary>
        /// Information whether the post is pinned
        ///</summary>
        [JsonProperty("is_pinned")]
        public int IsPinned { get; set; }
        [JsonProperty("comments")]
        public BaseCommentsInfo Comments { get; set; }

        ///<summary>
        /// Information whether the post is marked as ads
        ///</summary>
        [JsonProperty("marked_as_ads")]
        public int MarkedAsAds { get; set; }
    }
}