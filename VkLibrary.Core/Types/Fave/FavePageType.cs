using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
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