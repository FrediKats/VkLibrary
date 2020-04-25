using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum GroupsGroupFullAgeLimits
    {
        [EnumMember(Value = "no")]
        No = 1,
        [EnumMember(Value = "over 16")]
        Over16 = 2,
        [EnumMember(Value = "over 18")]
        Over18 = 3
    }
}