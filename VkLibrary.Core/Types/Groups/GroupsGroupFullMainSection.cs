using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Groups
{
    ///<summary>
    /// Main section of community
    ///</summary>
    public enum GroupsGroupFullMainSection
    {
        [EnumMember(Value = "absent")]
        Absent = 0,
        [EnumMember(Value = "photos")]
        Photos = 1,
        [EnumMember(Value = "topics")]
        Topics = 2,
        [EnumMember(Value = "audio")]
        Audio = 3,
        [EnumMember(Value = "video")]
        Video = 4,
        [EnumMember(Value = "market")]
        Market = 5
    }
}