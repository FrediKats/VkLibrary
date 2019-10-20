using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Media type
    ///</summary>
    public enum WidgetsCommentMediaType
    {
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "video")]
        Video
    }
}