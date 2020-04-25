using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Item type
    ///</summary>
    public enum NewsfeedNewsfeedItemType
    {
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "photo_tag")]
        PhotoTag,
        [EnumMember(Value = "wall_photo")]
        WallPhoto,
        [EnumMember(Value = "friend")]
        Friend,
        [EnumMember(Value = "note")]
        Note,
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "topic")]
        Topic,
        [EnumMember(Value = "digest")]
        Digest,
        [EnumMember(Value = "stories")]
        Stories
    }
}