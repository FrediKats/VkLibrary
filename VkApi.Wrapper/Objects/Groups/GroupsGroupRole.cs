using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
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