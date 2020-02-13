using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Docs
{
    ///<summary>
    /// Doc attachment type
    ///</summary>
    public enum DocsDocAttachmentType
    {
        [EnumMember(Value = "doc")]
        Doc,
        [EnumMember(Value = "graffiti")]
        Graffiti,
        [EnumMember(Value = "audio_message")]
        AudioMessage
    }
}