using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    public enum BaseSex
    {
        [EnumMember(Value = "unknown")]
        Unknown = 0,
        [EnumMember(Value = "female")]
        Female = 1,
        [EnumMember(Value = "male")]
        Male = 2
    }
}