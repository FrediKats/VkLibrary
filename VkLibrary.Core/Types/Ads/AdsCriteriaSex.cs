using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Ads
{
    ///<summary>
    /// Sex
    ///</summary>
    public enum AdsCriteriaSex
    {
        [EnumMember(Value = "any")]
        Any = 0,
        [EnumMember(Value = "male")]
        Male = 1,
        [EnumMember(Value = "female")]
        Female = 2
    }
}