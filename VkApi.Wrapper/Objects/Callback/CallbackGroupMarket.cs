using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum CallbackGroupMarket
    {
        [EnumMember(Value = "disabled")]
        Disabled = 0,
        [EnumMember(Value = "open")]
        Open = 1
    }
}