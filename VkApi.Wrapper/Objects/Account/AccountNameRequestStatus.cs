using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Request status
    ///</summary>
    public enum AccountNameRequestStatus
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "processing")]
        Processing,
        [EnumMember(Value = "declined")]
        Declined,
        [EnumMember(Value = "was_accepted")]
        WasAccepted,
        [EnumMember(Value = "was_declined")]
        WasDeclined,
        [EnumMember(Value = "declined_with_link")]
        DeclinedWithLink
    }
}