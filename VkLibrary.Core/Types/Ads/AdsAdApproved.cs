using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Ads
{
    ///<summary>
    /// Review status
    ///</summary>
    public enum AdsAdApproved
    {
        [EnumMember(Value = "not moderated")]
        NotModerated = 0,
        [EnumMember(Value = "pending moderation")]
        PendingModeration = 1,
        [EnumMember(Value = "approved")]
        Approved = 2,
        [EnumMember(Value = "rejected")]
        Rejected = 3
    }
}