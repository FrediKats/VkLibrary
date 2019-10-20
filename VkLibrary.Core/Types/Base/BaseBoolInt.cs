using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    public enum BaseBoolInt
    {
        [EnumMember(Value = "no")]
        No = 0,
        [EnumMember(Value = "yes")]
        Yes = 1
    }
}