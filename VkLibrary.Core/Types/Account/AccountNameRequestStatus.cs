using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Account
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
        WasDeclined
    }
}