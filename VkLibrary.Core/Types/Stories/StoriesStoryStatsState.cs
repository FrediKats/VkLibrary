using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Stories
{
    ///<summary>
    /// Statistic state
    ///</summary>
    public enum StoriesStoryStatsState
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off,
        [EnumMember(Value = "hidden")]
        Hidden
    }
}