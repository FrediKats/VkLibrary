using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Stories
{
    ///<summary>
    /// Story type.
    ///</summary>
    public enum StoriesStoryType
    {
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "video")]
        Video
    }
}