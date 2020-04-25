using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Settings parameters
    ///</summary>
    public enum AccountPushParamsSettings
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off,
        [EnumMember(Value = "fr_of_fr")]
        FrOfFr
    }
}