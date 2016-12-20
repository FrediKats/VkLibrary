using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Groups
{
    public class GetCallbackSettingsResponse
    {
        /// <summary>
        /// Whether notifications about wall replies edits enabled
        /// </summary>
        [JsonProperty("wall_reply_edit")]
        public int WallReplyEdit { get; set; }

        /// <summary>
        /// Whether notifications about anyone left the community enabled
        /// </summary>
        [JsonProperty("group_leave")]
        public int GroupLeave { get; set; }

        /// <summary>
        /// Whether notifications about new wall posts enabled
        /// </summary>
        [JsonProperty("wall_post_new")]
        public int WallPostNew { get; set; }

        /// <summary>
        /// Whether notifications about board posts restores enabled
        /// </summary>
        [JsonProperty("board_post_restore")]
        public int BoardPostRestore { get; set; }

        /// <summary>
        /// Whether notifications about anyone joined the community enabled
        /// </summary>
        [JsonProperty("group_join")]
        public int GroupJoin { get; set; }

        /// <summary>
        /// Whether notifications about denied messages enabled
        /// </summary>
        [JsonProperty("message_deny")]
        public int MessageDeny { get; set; }

        /// <summary>
        /// Whether notifications about new message enabled
        /// </summary>
        [JsonProperty("message_new")]
        public int MessageNew { get; set; }

        /// <summary>
        /// Whether notifications about new wall replies enabled
        /// </summary>
        [JsonProperty("wall_reply_new")]
        public int WallReplyNew { get; set; }

        /// <summary>
        /// Whether notifications about new board posts enabled
        /// </summary>
        [JsonProperty("board_post_new")]
        public int BoardPostNew { get; set; }

        /// <summary>
        /// Whether notifications about new video comments enabled
        /// </summary>
        [JsonProperty("video_comment_new")]
        public int VideoCommentNew { get; set; }

        /// <summary>
        /// Whether notifications about new videos enabled
        /// </summary>
        [JsonProperty("video_new")]
        public int VideoNew { get; set; }

        /// <summary>
        /// Whether notifications about board posts deleted enabled
        /// </summary>
        [JsonProperty("board_post_delete")]
        public int BoardPostDelete { get; set; }

        /// <summary>
        /// Whether notifications about allowed messages enabled
        /// </summary>
        [JsonProperty("message_allow")]
        public int MessageAllow { get; set; }

        /// <summary>
        /// Whether notifications about new audios enabled
        /// </summary>
        [JsonProperty("audio_new")]
        public int AudioNew { get; set; }

        /// <summary>
        /// Whether notifications about board posts edits enabled
        /// </summary>
        [JsonProperty("board_post_edit")]
        public int BoardPostEdit { get; set; }

        /// <summary>
        /// Whether notifications about new photos enabled
        /// </summary>
        [JsonProperty("photo_new")]
        public int PhotoNew { get; set; }

        /// <summary>
        /// Whether notifications about new photo comments enabled
        /// </summary>
        [JsonProperty("photo_comment_new")]
        public int PhotoCommentNew { get; set; }

        /// <summary>
        /// Whether notifications about new market comments enabled
        /// </summary>
        [JsonProperty("market_comment_new")]
        public int MarketCommentNew { get; set; }

    }
}
