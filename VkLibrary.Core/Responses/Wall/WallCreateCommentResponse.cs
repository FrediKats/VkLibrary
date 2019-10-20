using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
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