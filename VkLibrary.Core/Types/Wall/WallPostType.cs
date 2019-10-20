using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Post type
    ///</summary>
    public enum WallPostType
    {
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "copy")]
        Copy,
        [EnumMember(Value = "reply")]
        Reply,
        [EnumMember(Value = "postpone")]
        Postpone,
        [EnumMember(Value = "suggest")]
        Suggest
    }
}