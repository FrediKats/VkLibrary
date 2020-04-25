using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Story type.
    ///</summary>
    public enum StoriesStoryType
    {
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "live_active")]
        LiveActive,
        [EnumMember(Value = "live_finished")]
        LiveFinished
    }
}