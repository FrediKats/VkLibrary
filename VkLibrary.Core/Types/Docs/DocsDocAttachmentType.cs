using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
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