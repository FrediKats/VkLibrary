using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Groups
{
    public enum GroupsGroupTopics
    {
        [EnumMember(Value = "disabled")]
        Disabled = 0,
        [EnumMember(Value = "open")]
        Open = 1,
        [EnumMember(Value = "limited")]
        Limited = 2
    }
}