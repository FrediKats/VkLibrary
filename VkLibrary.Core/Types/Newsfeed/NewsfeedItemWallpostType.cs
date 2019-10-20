using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Post type
    ///</summary>
    public enum NewsfeedItemWallpostType
    {
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "copy")]
        Copy,
        [EnumMember(Value = "reply")]
        Reply
    }
}