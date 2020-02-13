using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Widgets
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