using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Owner type
    ///</summary>
    public enum GroupsOwnerXtrBanInfoType
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "profile")]
        Profile
    }
}