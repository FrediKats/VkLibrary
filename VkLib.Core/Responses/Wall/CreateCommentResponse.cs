using Newtonsoft.Json;

namespace VkLib.Responses.Wall
{
    public class CreateCommentResponse
    {
        /// <summary>
        ///     Created comment ID
        /// </summary>
        [JsonProperty("comment_id")]
        public int? CommentId { get; set; }
    }
}