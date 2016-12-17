using System;
using Newtonsoft.Json;

namespace VkLib.Types.Widgets 
{
    public class CommentReplies
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("replies")]
        public IEnumerable<CommentRepliesItem> Replies { get; set; }

        /// <summary>
        /// Comments number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Information whether current user can comment the post
        /// </summary>
        [JsonProperty("can_post")]
        public int? CanPost { get; set; }

    }
}
