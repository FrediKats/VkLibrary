using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsLongPollEvents
    {
        [JsonProperty("audio_new")]
        public int AudioNew { get; set; }
        [JsonProperty("board_post_delete")]
        public int BoardPostDelete { get; set; }
        [JsonProperty("board_post_edit")]
        public int BoardPostEdit { get; set; }
        [JsonProperty("board_post_new")]
        public int BoardPostNew { get; set; }
        [JsonProperty("board_post_restore")]
        public int BoardPostRestore { get; set; }
        [JsonProperty("group_change_photo")]
        public int GroupChangePhoto { get; set; }
        [JsonProperty("group_change_settings")]
        public int GroupChangeSettings { get; set; }
        [JsonProperty("group_join")]
        public int GroupJoin { get; set; }
        [JsonProperty("group_leave")]
        public int GroupLeave { get; set; }
        [JsonProperty("group_officers_edit")]
        public int GroupOfficersEdit { get; set; }
        [JsonProperty("lead_forms_new")]
        public int LeadFormsNew { get; set; }
        [JsonProperty("market_comment_delete")]
        public int MarketCommentDelete { get; set; }
        [JsonProperty("market_comment_edit")]
        public int MarketCommentEdit { get; set; }
        [JsonProperty("market_comment_new")]
        public int MarketCommentNew { get; set; }
        [JsonProperty("market_comment_restore")]
        public int MarketCommentRestore { get; set; }
        [JsonProperty("message_allow")]
        public int MessageAllow { get; set; }
        [JsonProperty("message_deny")]
        public int MessageDeny { get; set; }
        [JsonProperty("message_new")]
        public int MessageNew { get; set; }
        [JsonProperty("message_read")]
        public int MessageRead { get; set; }
        [JsonProperty("message_reply")]
        public int MessageReply { get; set; }
        [JsonProperty("message_typing_state")]
        public int MessageTypingState { get; set; }
        [JsonProperty("messages_edit")]
        public int MessagesEdit { get; set; }
        [JsonProperty("photo_comment_delete")]
        public int PhotoCommentDelete { get; set; }
        [JsonProperty("photo_comment_edit")]
        public int PhotoCommentEdit { get; set; }
        [JsonProperty("photo_comment_new")]
        public int PhotoCommentNew { get; set; }
        [JsonProperty("photo_comment_restore")]
        public int PhotoCommentRestore { get; set; }
        [JsonProperty("photo_new")]
        public int PhotoNew { get; set; }
        [JsonProperty("poll_vote_new")]
        public int PollVoteNew { get; set; }
        [JsonProperty("user_block")]
        public int UserBlock { get; set; }
        [JsonProperty("user_unblock")]
        public int UserUnblock { get; set; }
        [JsonProperty("video_comment_delete")]
        public int VideoCommentDelete { get; set; }
        [JsonProperty("video_comment_edit")]
        public int VideoCommentEdit { get; set; }
        [JsonProperty("video_comment_new")]
        public int VideoCommentNew { get; set; }
        [JsonProperty("video_comment_restore")]
        public int VideoCommentRestore { get; set; }
        [JsonProperty("video_new")]
        public int VideoNew { get; set; }
        [JsonProperty("wall_post_new")]
        public int WallPostNew { get; set; }
        [JsonProperty("wall_reply_delete")]
        public int WallReplyDelete { get; set; }
        [JsonProperty("wall_reply_edit")]
        public int WallReplyEdit { get; set; }
        [JsonProperty("wall_reply_new")]
        public int WallReplyNew { get; set; }
        [JsonProperty("wall_reply_restore")]
        public int WallReplyRestore { get; set; }
        [JsonProperty("wall_repost")]
        public int WallRepost { get; set; }
    }
}