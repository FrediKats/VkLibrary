using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Groups
{
    public enum GroupsGroupAccess
    {
        [EnumMember(Value = "open")]
        Open = 0,
        [EnumMember(Value = "closed")]
        Closed = 1,
        [EnumMember(Value = "private")]
        Private = 2
    }
}