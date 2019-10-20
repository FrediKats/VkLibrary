using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class CommentThread
    {
        ///<summary>
        /// Information whether current user can comment the post
        ///</summary>
        [JsonProperty("can_post")]
        public Boolean CanPost { get; set; }

        ///<summary>
        /// Comments number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// Information whether groups can comment the post
        ///</summary>
        [JsonProperty("groups_can_post")]
        public Boolean GroupsCanPost { get; set; }
        [JsonProperty("items")]
        public WallWallComment[] Items { get; set; }

        ///<summary>
        /// Information whether recommended to display reply button
        ///</summary>
        [JsonProperty("show_reply_button")]
        public Boolean ShowReplyButton { get; set; }
    }
}