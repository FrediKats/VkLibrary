using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Groups
{
    ///<summary>
    /// Community type
    ///</summary>
    public enum GroupsGroupType
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "page")]
        Page,
        [EnumMember(Value = "event")]
        Event
    }
}