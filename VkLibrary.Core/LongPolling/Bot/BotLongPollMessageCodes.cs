using System.Runtime.Serialization;

namespace VkApi.Wrapper.LongPolling.Bot
{
    public enum BotLongPollMessageCodes
    {
        Unknown = 0,

        [EnumMember(Value = "message_new")]
        MessageNew,

        [EnumMember(Value = "message_reply")]
        MessageReply,

        [EnumMember(Value = "message_allow")]
        MessageAllow,

        [EnumMember(Value = "messages_deny")]
        MessageDeny,

        [EnumMember(Value = "photo_new")]
        PhotoNew,

        [EnumMember(Value = "photo_comment_new")]
        PhotoCommentNew,

        [EnumMember(Value = "photo_comment_edit")]
        PhotoCommentEdit,

        [EnumMember(Value = "photo_comment_restore")]
        PhotoCommentRestore,

        //TODO: implement other: https://vk.com/dev/groups_events

    }
}