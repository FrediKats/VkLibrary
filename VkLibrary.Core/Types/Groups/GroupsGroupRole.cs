using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Groups
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