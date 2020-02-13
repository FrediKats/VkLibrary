using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Groups
{
    ///<summary>
    /// User's credentials as community admin
    ///</summary>
    public enum GroupsMemberRoleStatus
    {
        [EnumMember(Value = "moderator")]
        Moderator,
        [EnumMember(Value = "editor")]
        Editor,
        [EnumMember(Value = "administrator")]
        Administrator,
        [EnumMember(Value = "creator")]
        Creator
    }
}