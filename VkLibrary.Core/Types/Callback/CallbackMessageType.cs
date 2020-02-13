using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Callback
{
    public enum CallbackMessageType
    {
        [EnumMember(Value = "confirmation")]
        Confirmation,
        [EnumMember(Value = "group_change_photo")]
        GroupChangePhoto,
        [EnumMember(Value = "group_change_settings")]
        GroupChangeSettings,
        [EnumMember(Value = "group_officers_edit")]
        GroupOfficersEdit,
        [EnumMember(Value = "lead_forms_new")]
        LeadFormsNew,
        [EnumMember(Value = "market_comment_delete")]
        MarketCommentDelete,
        [EnumMember(Value = "market_comment_edit")]
        MarketCommentEdit,
        [EnumMember(Value = "market_comment_restore")]
        MarketCommentRestore,
        [EnumMember(Value = "message_allow")]
        MessageAllow,
        [EnumMember(Value = "message_deny")]
        MessageDeny,
        [EnumMember(Value = "message_read")]
        MessageRead,
        [EnumMember(Value = "message_reply")]
        MessageReply,
        [EnumMember(Value = "message_typing_state")]
        MessageTypingState,
        [EnumMember(Value = "messages_edit")]
        MessagesEdit,
        [EnumMember(Value = "photo_comment_delete")]
        PhotoCommentDelete,
        [EnumMember(Value = "photo_comment_edit")]
        PhotoCommentEdit,
        [EnumMember(Value = "photo_comment_restore")]
        PhotoCommentRestore,
        [EnumMember(Value = "poll_vote_new")]
        PollVoteNew,
        [EnumMember(Value = "user_block")]
        UserBlock,
        [EnumMember(Value = "user_unblock")]
        UserUnblock,
        [EnumMember(Value = "video_comment_delete")]
        VideoCommentDelete,
        [EnumMember(Value = "video_comment_edit")]
        VideoCommentEdit,
        [EnumMember(Value = "video_comment_restore")]
        VideoCommentRestore,
        [EnumMember(Value = "wall_reply_delete")]
        WallReplyDelete,
        [EnumMember(Value = "wall_reply_restore")]
        WallReplyRestore,
        [EnumMember(Value = "wall_repost")]
        WallRepost
    }
}