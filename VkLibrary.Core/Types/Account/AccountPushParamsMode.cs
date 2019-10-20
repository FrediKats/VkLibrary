using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Settings parameters
    ///</summary>
    public enum AccountPushParamsMode
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off,
        [EnumMember(Value = "no_sound")]
        NoSound,
        [EnumMember(Value = "no_text")]
        NoText
    }
}