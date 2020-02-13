using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Groups
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