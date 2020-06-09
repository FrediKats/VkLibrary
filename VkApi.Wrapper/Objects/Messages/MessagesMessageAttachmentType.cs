using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Attachment type
    ///</summary>
    public enum MessagesMessageAttachmentType
    {
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "doc")]
        Doc,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "market_album")]
        MarketAlbum,
        [EnumMember(Value = "gift")]
        Gift,
        [EnumMember(Value = "sticker")]
        Sticker,
        [EnumMember(Value = "wall")]
        Wall,
        [EnumMember(Value = "wall_reply")]
        WallReply,
        [EnumMember(Value = "article")]
        Article,
        [EnumMember(Value = "graffiti")]
        Graffiti,
        [EnumMember(Value = "audio_message")]
        AudioMessage,

        [EnumMember(Value = "poll")]
        Poll
    }
}