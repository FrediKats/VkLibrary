using Newtonsoft.Json;
using VkLibrary.Core.Types.Base;

namespace VkLibrary.Core.Types.Newsfeed
{
    public class ItemTopic
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("comments")]
        public CommentsInfo Comments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public LikesInfo Likes { get; set; }

        /// <summary>
        /// Topic post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }

        /// <summary>
        /// Post text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}