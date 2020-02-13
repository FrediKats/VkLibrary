using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Base
{
    public enum BaseBoolInt
    {
        [EnumMember(Value = "no")]
        No = 0,
        [EnumMember(Value = "yes")]
        Yes = 1
    }
}