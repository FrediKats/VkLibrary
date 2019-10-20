using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    public enum GroupsGroupRole
    {
        [EnumMember(Value = "moderator")]
        Moderator,
        [EnumMember(Value = "editor")]
        Editor,
        [EnumMember(Value = "administrator")]
        Administrator
    }
}