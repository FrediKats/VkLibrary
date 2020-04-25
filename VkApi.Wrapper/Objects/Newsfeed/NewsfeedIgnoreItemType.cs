using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum NewsfeedIgnoreItemType
    {
        ///<summary>
        /// post on the wall
        ///</summary>
        [EnumMember(Value = "wall")]
        Wall,
        ///<summary>
        /// tag on a photo
        ///</summary>
        [EnumMember(Value = "tag")]
        Tag,
        ///<summary>
        /// profile photo
        ///</summary>
        [EnumMember(Value = "profilephoto")]
        Profilephoto,
        ///<summary>
        /// video
        ///</summary>
        [EnumMember(Value = "video")]
        Video,
        ///<summary>
        /// photo
        ///</summary>
        [EnumMember(Value = "photo")]
        Photo,
        ///<summary>
        /// audio
        ///</summary>
        [EnumMember(Value = "audio")]
        Audio
    }
}