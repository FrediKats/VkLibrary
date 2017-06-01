using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Base;

namespace VkLib.Types.Wall
{
    public class WallpostFull : Wallpost
    {
        /// <summary>
        ///     Post creator ID (if post still can be edited)
        /// </summary>
        [JsonProperty("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("copy_history")]
        public IEnumerable<WallpostFull> CopyHistory { get; set; }

        /// <summary>
        ///     Information whether current user can edit the post
        /// </summary>
        [JsonProperty("can_edit")]
        public int? CanEdit { get; set; }

        /// <summary>
        ///     Information whether the post is pinned
        /// </summary>
        [JsonProperty("is_pinned")]
        public int? IsPinned { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("comments")]
        public CommentsInfo Comments { get; set; }

        /// <summary>
        ///     Information whether current user can delete the post
        /// </summary>
        [JsonProperty("can_delete")]
        public int? CanDelete { get; set; }

        /// <summary>
        ///     Information whether current user can pin the post
        /// </summary>
        [JsonProperty("can_pin")]
        public int? CanPin { get; set; }

        /// <summary>
        ///     Info about post likes count
        /// </summary>
        [JsonProperty("likes")]
        public LikesInfo Likes { get; set; }

        /// <summary>
        ///     Info about post views count
        /// </summary>
        [JsonProperty("views")]
        public ViewsInfo Views { get; set; }

        /// <summary>
        ///     Info about post reposts count
        /// </summary>
        [JsonProperty("reposts")]
        public RepostsInfo Reposts { get; set; }
    }
}