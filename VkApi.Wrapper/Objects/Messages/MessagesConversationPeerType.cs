using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Peer type
    ///</summary>
    public enum MessagesConversationPeerType
    {
        [EnumMember(Value = "chat")]
        Chat,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group
    }
}