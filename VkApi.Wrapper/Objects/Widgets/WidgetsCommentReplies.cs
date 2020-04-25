using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class WidgetsCommentReplies
    {
        ///<summary>
        /// Information whether current user can comment the post
        ///</summary>
        [JsonProperty("can_post")]
        public int CanPost { get; set; }

        ///<summary>
        /// Comments number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("replies")]
        public WidgetsCommentRepliesItem[] Replies { get; set; }
    }
}