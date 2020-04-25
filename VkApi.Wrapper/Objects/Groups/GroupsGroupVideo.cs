using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum GroupsGroupVideo
    {
        [EnumMember(Value = "disabled")]
        Disabled = 0,
        [EnumMember(Value = "open")]
        Open = 1,
        [EnumMember(Value = "limited")]
        Limited = 2
    }
}