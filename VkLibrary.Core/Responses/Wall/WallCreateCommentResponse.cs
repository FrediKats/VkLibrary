using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Wall
{
    public class WallCreateCommentResponse
    {
        ///<summary>
        /// Created comment ID
        ///</summary>
        [JsonProperty("comment_id")]
        public int CommentId { get; set; }
    }
}