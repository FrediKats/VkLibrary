using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Utils
{
    ///<summary>
    /// Link status
    ///</summary>
    public enum UtilsLinkCheckedStatus
    {
        [EnumMember(Value = "not_banned")]
        NotBanned,
        [EnumMember(Value = "banned")]
        Banned,
        [EnumMember(Value = "processing")]
        Processing
    }
}