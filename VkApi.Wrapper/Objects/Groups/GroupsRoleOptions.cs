using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// User's credentials as community admin
    ///</summary>
    public enum GroupsRoleOptions
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