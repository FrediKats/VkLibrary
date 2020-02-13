using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Ads
{
    ///<summary>
    /// Account type
    ///</summary>
    public enum AdsAccountType
    {
        [EnumMember(Value = "general")]
        General,
        [EnumMember(Value = "agency")]
        Agency
    }
}