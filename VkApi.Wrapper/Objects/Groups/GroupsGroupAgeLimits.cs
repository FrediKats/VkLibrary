using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum GroupsGroupAgeLimits
    {
        [EnumMember(Value = "unlimited")]
        Unlimited = 1,
        [EnumMember(Value = "16 plus")]
        _16Plus = 2,
        [EnumMember(Value = "18 plus")]
        _18Plus = 3
    }
}