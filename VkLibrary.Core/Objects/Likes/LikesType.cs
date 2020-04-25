using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum LikesType
    {
        [EnumMember(Value = "post")]
        Post,
        [EnumMember(Value = "comment")]
        Comment,
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "note")]
        Note,
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "photo_comment")]
        PhotoComment,
        [EnumMember(Value = "video_comment")]
        VideoComment,
        [EnumMember(Value = "topic_comment")]
        TopicComment,
        [EnumMember(Value = "market_comment")]
        MarketComment,
        [EnumMember(Value = "sitepage")]
        Sitepage
    }
}