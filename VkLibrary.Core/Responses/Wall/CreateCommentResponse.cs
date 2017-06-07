using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Wall
{
    /// <summary>
    /// API CreateCommentResponse.
    /// </summary>
    public class CreateCommentResponse
    {
        /// <summary>
        /// Created comment ID
        /// </summary>
        [JsonProperty("comment_id")]
        public int? CommentId { get; set; }
    }
}