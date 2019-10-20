using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Action status
    ///</summary>
    public enum MessagesMessageActionStatus
    {
        [EnumMember(Value = "chat_photo_update")]
        ChatPhotoUpdate,
        [EnumMember(Value = "chat_photo_remove")]
        ChatPhotoRemove,
        [EnumMember(Value = "chat_create")]
        ChatCreate,
        [EnumMember(Value = "chat_title_update")]
        ChatTitleUpdate,
        [EnumMember(Value = "chat_invite_user")]
        ChatInviteUser,
        [EnumMember(Value = "chat_kick_user")]
        ChatKickUser,
        [EnumMember(Value = "chat_pin_message")]
        ChatPinMessage,
        [EnumMember(Value = "chat_unpin_message")]
        ChatUnpinMessage,
        [EnumMember(Value = "chat_invite_user_by_link")]
        ChatInviteUserByLink
    }
}