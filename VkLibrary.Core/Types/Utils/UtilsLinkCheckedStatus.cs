using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
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