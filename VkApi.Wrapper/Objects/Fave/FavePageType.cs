using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum FavePageType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "hints")]
        Hints
    }
}