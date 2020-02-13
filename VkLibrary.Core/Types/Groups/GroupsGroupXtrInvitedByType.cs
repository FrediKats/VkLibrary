using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Groups
{
    ///<summary>
    /// Community type
    ///</summary>
    public enum GroupsGroupXtrInvitedByType
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "page")]
        Page,
        [EnumMember(Value = "event")]
        Event
    }
}