using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum FaveBookmarkType
    {
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "product")]
        Product,
        [EnumMember(Value = "article")]
        Article,
        [EnumMember(Value = "link")]
        Link
    }
}