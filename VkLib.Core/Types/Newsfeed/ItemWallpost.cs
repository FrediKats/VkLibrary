using System;
using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed 
{
    public class ItemWallpost
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("comments")]
        public CommentsInfo Comments { get; set; }

        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post_source")]
        public PostSource PostSource { get; set; }

        /// <summary>
        /// Post type
        /// </summary>
        [JsonProperty("post_type")]
        public string PostType { get; set; }

        /// <summary>
        /// Post text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reposts")]
        public RepostsInfo Reposts { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("attachments")]
        public IEnumerable<WallpostAttachment> Attachments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("geo")]
        public Geo Geo { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("copy_history")]
        public IEnumerable<Wallpost> CopyHistory { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public LikesInfo Likes { get; set; }

    }
}
