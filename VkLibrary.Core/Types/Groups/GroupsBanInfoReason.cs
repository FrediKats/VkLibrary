using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Groups
{
    ///<summary>
    /// Ban reason
    ///</summary>
    public enum GroupsBanInfoReason
    {
        [EnumMember(Value = "other")]
        Other = 0,
        [EnumMember(Value = "spam")]
        Spam = 1,
        [EnumMember(Value = "verbal abuse")]
        VerbalAbuse = 2,
        [EnumMember(Value = "strong language")]
        StrongLanguage = 3,
        [EnumMember(Value = "flood")]
        Flood = 4
    }
}