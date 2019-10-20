using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Attachment type
    ///</summary>
    public enum WallWallpostAttachmentType
    {
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "posted_photo")]
        PostedPhoto,
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "doc")]
        Doc,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "graffiti")]
        Graffiti,
        [EnumMember(Value = "note")]
        Note,
        [EnumMember(Value = "app")]
        App,
        [EnumMember(Value = "poll")]
        Poll,
        [EnumMember(Value = "page")]
        Page,
        [EnumMember(Value = "album")]
        Album,
        [EnumMember(Value = "photos_list")]
        PhotosList,
        [EnumMember(Value = "market_market_album")]
        MarketMarketAlbum,
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "event")]
        Event
    }
}