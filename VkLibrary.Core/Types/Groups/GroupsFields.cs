using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    public enum GroupsFields
    {
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "member_status")]
        MemberStatus,
        [EnumMember(Value = "is_favorite")]
        IsFavorite,
        [EnumMember(Value = "is_subscribed")]
        IsSubscribed,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "country")]
        Country,
        [EnumMember(Value = "verified")]
        Verified,
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "wiki_page")]
        WikiPage,
        [EnumMember(Value = "members_count")]
        MembersCount,
        [EnumMember(Value = "counters")]
        Counters,
        [EnumMember(Value = "cover")]
        Cover,
        [EnumMember(Value = "can_post")]
        CanPost,
        [EnumMember(Value = "can_see_all_posts")]
        CanSeeAllPosts,
        [EnumMember(Value = "activity")]
        Activity,
        [EnumMember(Value = "fixed_post")]
        FixedPost,
        [EnumMember(Value = "can_create_topic")]
        CanCreateTopic,
        [EnumMember(Value = "can_upload_video")]
        CanUploadVideo,
        [EnumMember(Value = "has_photo")]
        HasPhoto,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "main_album_id")]
        MainAlbumId,
        [EnumMember(Value = "links")]
        Links,
        [EnumMember(Value = "contacts")]
        Contacts,
        [EnumMember(Value = "site")]
        Site,
        [EnumMember(Value = "main_section")]
        MainSection,
        [EnumMember(Value = "trending")]
        Trending,
        [EnumMember(Value = "can_message")]
        CanMessage,
        [EnumMember(Value = "is_market_cart_enabled")]
        IsMarketCartEnabled,
        [EnumMember(Value = "is_messages_blocked")]
        IsMessagesBlocked,
        [EnumMember(Value = "can_send_notify")]
        CanSendNotify,
        [EnumMember(Value = "online_status")]
        OnlineStatus,
        [EnumMember(Value = "start_date")]
        StartDate,
        [EnumMember(Value = "finish_date")]
        FinishDate,
        [EnumMember(Value = "age_limits")]
        AgeLimits,
        [EnumMember(Value = "ban_info")]
        BanInfo,
        [EnumMember(Value = "action_button")]
        ActionButton,
        [EnumMember(Value = "author_id")]
        AuthorId,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "has_market_app")]
        HasMarketApp,
        [EnumMember(Value = "addresses")]
        Addresses,
        [EnumMember(Value = "live_covers")]
        LiveCovers,
        [EnumMember(Value = "is_adult")]
        IsAdult,
        [EnumMember(Value = "can_subscribe_posts")]
        CanSubscribePosts,
        [EnumMember(Value = "warning_notification")]
        WarningNotification
    }
}