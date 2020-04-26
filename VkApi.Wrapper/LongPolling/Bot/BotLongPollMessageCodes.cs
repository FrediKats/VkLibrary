using System.Runtime.Serialization;

namespace VkApi.Wrapper.LongPolling.Bot
{
    /// <summary>
    /// Community events
    /// </summary>
    public enum BotLongPollMessageCodes
    {
        Unknown = 0,

        /// <summary>
        /// New message received
        /// </summary>
        [EnumMember(Value = "message_new")] MessageNew,

        //TODO: Ensure it's correct comment.
        /// <summary>
        /// New message sent
        /// </summary>
        [EnumMember(Value = "message_reply")] MessageReply,

        /// <summary>
        /// New user consent to messages sending
        /// </summary>
        [EnumMember(Value = "message_allow")] MessageAllow,

        /// <summary>
        /// New user prohibition to messages sending
        /// </summary>
        [EnumMember(Value = "messages_deny")] MessageDeny,

        /// <summary>
        /// New photo in a community
        /// </summary>
        [EnumMember(Value = "photo_new")] PhotoNew,

        /// <summary>
        /// New photo comment
        /// </summary>
        [EnumMember(Value = "photo_comment_new")] PhotoCommentNew,

        /// <summary>
        /// Editing a photo comment
        /// </summary>
        [EnumMember(Value = "photo_comment_edit")] PhotoCommentEdit,

        /// <summary>
        /// Restoring a photo comment
        /// </summary>
        [EnumMember(Value = "photo_comment_restore")] PhotoCommentRestore,

        /// <summary>
        /// Deleting a photo comment
        /// </summary>
        [EnumMember(Value = "photo_comment_delete")] PhotoCommentDelete,

        /// <summary>
        /// New audio in a community list
        /// </summary>
        [EnumMember(Value = "audio_new")] AudioNew,

        /// <summary>
        /// New video in a community list
        /// </summary>
        [EnumMember(Value = "video_new")] VideoNew,

        /// <summary>
        /// New video comment
        /// </summary>
        [EnumMember(Value = "video_comment_new")] VideoCommentNew,

        /// <summary>
        /// Editing a video comment
        /// </summary>
        [EnumMember(Value = "video_comment_edit")] VideoCommentEdit,

        /// <summary>
        /// Restoring a video comment
        /// </summary>
        [EnumMember(Value = "video_comment_restore")] VideoCommentRestore,

        /// <summary>
        /// Deleting a video comment
        /// </summary>
        [EnumMember(Value = "video_comment_delete")] VideoCommentDelete,

        /// <summary>
        /// Adding a post on wall
        /// </summary>
        [EnumMember(Value = "wall_post_new")] WallPostNew,

        /// <summary>
        /// New repost
        /// </summary>
        [EnumMember(Value = "wall_repost")] WallRepost,

        /// <summary>
        /// New comment on wall
        /// </summary>
        [EnumMember(Value = "wall_reply_new")] WallReplyNew,

        /// <summary>
        /// Editing a comment on wall
        /// </summary>
        [EnumMember(Value = "wall_reply_edit")] WallReplyEdit,

        /// <summary>
        /// Restoring a comment on wall
        /// </summary>
        [EnumMember(Value = "wall_reply_restore")] WallReplyRestore,

        /// <summary>
        /// Deleting a comment on wall
        /// </summary>
        [EnumMember(Value = "wall_reply_delete")] WallReplyDelete,

        /// <summary>
        /// New comment in a board
        /// </summary>
        [EnumMember(Value = "board_post_new")] BoardPostNew,

        /// <summary>
        /// Editing a board comment
        /// </summary>
        [EnumMember(Value = "board_post_edit")] BoardPostEdit,

        /// <summary>
        /// Restoring a board comment
        /// </summary>
        [EnumMember(Value = "board_post_restore")] BoardPostRestore,

        /// <summary>
        /// Deleting a board comment
        /// </summary>
        [EnumMember(Value = "board_post_delete")] BoardPostDelete,

        /// <summary>
        /// New comment to a market item
        /// </summary>
        [EnumMember(Value = "market_comment_new")] MarketCommentNew,

        /// <summary>
        /// Editing a market comment
        /// </summary>
        [EnumMember(Value = "market_comment_edit")] MarketCommentEdit,

        /// <summary>
        /// Restoring a market comment
        /// </summary>
        [EnumMember(Value = "market_comment_restore")] MarketCommentRestore,

        /// <summary>
        /// Deleting a market comment
        /// </summary>
        [EnumMember(Value = "market_comment_delete")] MarketCommentDelete,

        /// <summary>
        /// Member removed from a community
        /// </summary>
        [EnumMember(Value = "group_leave")] GroupLeave,

        /// <summary>
        /// New member or join request
        /// </summary>
        [EnumMember(Value = "group_join")] GroupJoin,

        /// <summary>
        /// New user in the blacklist
        /// </summary>
        [EnumMember(Value = "user_block")] UserBlock,

        /// <summary>
        /// User has been deleted from the blacklist
        /// </summary>
        [EnumMember(Value = "user_unblock")] UserUnblock,

        /// <summary>
        /// New vote in a public poll
        /// </summary>
        [EnumMember(Value = "poll_vote_new")] PollVoteNew,

        /// <summary>
        /// Changes in the administrators list
        /// </summary>
        [EnumMember(Value = "group_officers_edit")] GroupOfficersEdit,

        /// <summary>
        /// Changes in a community settings
        /// </summary>
        [EnumMember(Value = "group_change_settings")] GroupChangeSettings,

        /// <summary>
        /// Changes of community main photo
        /// </summary>
        [EnumMember(Value = "group_change_photo")] GroupChangePhoto,
    }
}