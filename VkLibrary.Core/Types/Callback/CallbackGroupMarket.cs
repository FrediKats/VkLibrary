using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Callback
{
    public enum CallbackGroupMarket
    {
        [EnumMember(Value = "disabled")]
        Disabled = 0,
        [EnumMember(Value = "open")]
        Open = 1
    }
}