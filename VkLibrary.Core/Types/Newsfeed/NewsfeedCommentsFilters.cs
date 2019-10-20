using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    public enum NewsfeedCommentsFilters
    {
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "topic")]
        Topic,
        [EnumMember(Value = "note")]
        Note
    }
}