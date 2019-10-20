using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
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