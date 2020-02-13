using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Account
{
    ///<summary>
    /// Settings parameters
    ///</summary>
    public enum AccountPushParamsOnoff
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off
    }
}