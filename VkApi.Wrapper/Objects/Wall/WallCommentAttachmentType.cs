using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Attachment type
    ///</summary>
    public enum WallCommentAttachmentType
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
        [EnumMember(Value = "note")]
        Note,
        [EnumMember(Value = "page")]
        Page,
        [EnumMember(Value = "market_market_album")]
        MarketMarketAlbum,
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "sticker")]
        Sticker
    }
}