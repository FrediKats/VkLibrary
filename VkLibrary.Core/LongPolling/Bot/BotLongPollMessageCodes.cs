using System.Runtime.Serialization;

namespace VkApi.Wrapper.LongPolling.Bot
{
    //TODO: Add description
    /// <summary>
    /// Community events
    /// </summary>
    public enum BotLongPollMessageCodes
    {
        Unknown = 0,

        [EnumMember(Value = "message_new")] MessageNew,
        [EnumMember(Value = "message_reply")] MessageReply,
        [EnumMember(Value = "message_allow")] MessageAllow,
        [EnumMember(Value = "messages_deny")] MessageDeny,

        [EnumMember(Value = "photo_new")] PhotoNew,
        [EnumMember(Value = "photo_comment_new")] PhotoCommentNew,
        [EnumMember(Value = "photo_comment_edit")] PhotoCommentEdit,
        [EnumMember(Value = "photo_comment_restore")] PhotoCommentRestore,
        [EnumMember(Value = "photo_comment_delete")] PhotoCommentDelete,

        [EnumMember(Value = "audio_new")] AudioNew,

        [EnumMember(Value = "video_new")] VideoNew,
        [EnumMember(Value = "video_comment_new")] VideoCommentNew,
        [EnumMember(Value = "video_comment_edit")] VideoCommentEdit,
        [EnumMember(Value = "video_comment_restore")] VideoCommentRestore,
        [EnumMember(Value = "video_comment_delete")] VideoCommentDelete,

        [EnumMember(Value = "wall_post_new")] WallPostNew,
        [EnumMember(Value = "wall_repost")] WallRepost,

        [EnumMember(Value = "wall_reply_new")] WallReplyNew,
        [EnumMember(Value = "wall_reply_edit")] WallReplyEdit,
        [EnumMember(Value = "wall_reply_restore")] WallReplyRestore,
        [EnumMember(Value = "wall_reply_delete")] WallReplyDelete,

        [EnumMember(Value = "board_post_new")] BoardPostNew,
        [EnumMember(Value = "board_post_edit")] BoardPostEdit,
        [EnumMember(Value = "board_post_restore")] BoardPostRestore,
        [EnumMember(Value = "board_post_delete")] BoardPostDelete,

        [EnumMember(Value = "market_comment_new")] MarketCommentNew,
        [EnumMember(Value = "market_comment_edit")] MarketCommentEdit,
        [EnumMember(Value = "market_comment_restore")] MarketCommentRestore,
        [EnumMember(Value = "market_comment_delete")] MarketCommentDelete,

        [EnumMember(Value = "group_leave")] GroupLeave,
        [EnumMember(Value = "group_join")] GroupJoin,
        [EnumMember(Value = "user_block")] UserBlock,
        [EnumMember(Value = "user_unblock")] UserUnblock,

        [EnumMember(Value = "poll_vote_new")] PollVoteNew,
        [EnumMember(Value = "group_officers_edit")] GroupOfficersEdit,
        [EnumMember(Value = "group_change_settings")] GroupChangeSettings,
        [EnumMember(Value = "group_change_photo")] GroupChangePhoto,
    }
}