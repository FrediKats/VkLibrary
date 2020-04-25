using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    public enum BaseUserGroupFields
    {
        [EnumMember(Value = "about")]
        About,
        [EnumMember(Value = "action_button")]
        ActionButton,
        [EnumMember(Value = "activities")]
        Activities,
        [EnumMember(Value = "activity")]
        Activity,
        [EnumMember(Value = "addresses")]
        Addresses,
        [EnumMember(Value = "admin_level")]
        AdminLevel,
        [EnumMember(Value = "age_limits")]
        AgeLimits,
        [EnumMember(Value = "author_id")]
        AuthorId,
        [EnumMember(Value = "ban_info")]
        BanInfo,
        [EnumMember(Value = "bdate")]
        Bdate,
        [EnumMember(Value = "blacklisted")]
        Blacklisted,
        [EnumMember(Value = "blacklisted_by_me")]
        BlacklistedByMe,
        [EnumMember(Value = "books")]
        Books,
        [EnumMember(Value = "can_create_topic")]
        CanCreateTopic,
        [EnumMember(Value = "can_message")]
        CanMessage,
        [EnumMember(Value = "can_post")]
        CanPost,
        [EnumMember(Value = "can_see_all_posts")]
        CanSeeAllPosts,
        [EnumMember(Value = "can_see_audio")]
        CanSeeAudio,
        [EnumMember(Value = "can_send_friend_request")]
        CanSendFriendRequest,
        [EnumMember(Value = "can_upload_video")]
        CanUploadVideo,
        [EnumMember(Value = "can_write_private_message")]
        CanWritePrivateMessage,
        [EnumMember(Value = "career")]
        Career,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "common_count")]
        CommonCount,
        [EnumMember(Value = "connections")]
        Connections,
        [EnumMember(Value = "contacts")]
        Contacts,
        [EnumMember(Value = "counters")]
        Counters,
        [EnumMember(Value = "country")]
        Country,
        [EnumMember(Value = "cover")]
        Cover,
        [EnumMember(Value = "crop_photo")]
        CropPhoto,
        [EnumMember(Value = "deactivated")]
        Deactivated,
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "domain")]
        Domain,
        [EnumMember(Value = "education")]
        Education,
        [EnumMember(Value = "exports")]
        Exports,
        [EnumMember(Value = "finish_date")]
        FinishDate,
        [EnumMember(Value = "fixed_post")]
        FixedPost,
        [EnumMember(Value = "followers_count")]
        FollowersCount,
        [EnumMember(Value = "friend_status")]
        FriendStatus,
        [EnumMember(Value = "games")]
        Games,
        [EnumMember(Value = "has_market_app")]
        HasMarketApp,
        [EnumMember(Value = "has_mobile")]
        HasMobile,
        [EnumMember(Value = "has_photo")]
        HasPhoto,
        [EnumMember(Value = "home_town")]
        HomeTown,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "interests")]
        Interests,
        [EnumMember(Value = "is_admin")]
        IsAdmin,
        [EnumMember(Value = "is_closed")]
        IsClosed,
        [EnumMember(Value = "is_favorite")]
        IsFavorite,
        [EnumMember(Value = "is_friend")]
        IsFriend,
        [EnumMember(Value = "is_hidden_from_feed")]
        IsHiddenFromFeed,
        [EnumMember(Value = "is_member")]
        IsMember,
        [EnumMember(Value = "is_messages_blocked")]
        IsMessagesBlocked,
        [EnumMember(Value = "can_send_notify")]
        CanSendNotify,
        [EnumMember(Value = "is_subscribed")]
        IsSubscribed,
        [EnumMember(Value = "last_seen")]
        LastSeen,
        [EnumMember(Value = "links")]
        Links,
        [EnumMember(Value = "lists")]
        Lists,
        [EnumMember(Value = "maiden_name")]
        MaidenName,
        [EnumMember(Value = "main_album_id")]
        MainAlbumId,
        [EnumMember(Value = "main_section")]
        MainSection,
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "member_status")]
        MemberStatus,
        [EnumMember(Value = "members_count")]
        MembersCount,
        [EnumMember(Value = "military")]
        Military,
        [EnumMember(Value = "movies")]
        Movies,
        [EnumMember(Value = "music")]
        Music,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "nickname")]
        Nickname,
        [EnumMember(Value = "occupation")]
        Occupation,
        [EnumMember(Value = "online")]
        Online,
        [EnumMember(Value = "online_status")]
        OnlineStatus,
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "photo_100")]
        Photo100,
        [EnumMember(Value = "photo_200")]
        Photo200,
        [EnumMember(Value = "photo_200_orig")]
        Photo200Orig,
        [EnumMember(Value = "photo_400_orig")]
        Photo400Orig,
        [EnumMember(Value = "photo_50")]
        Photo50,
        [EnumMember(Value = "photo_id")]
        PhotoId,
        [EnumMember(Value = "photo_max")]
        PhotoMax,
        [EnumMember(Value = "photo_max_orig")]
        PhotoMaxOrig,
        [EnumMember(Value = "quotes")]
        Quotes,
        [EnumMember(Value = "relation")]
        Relation,
        [EnumMember(Value = "relatives")]
        Relatives,
        [EnumMember(Value = "schools")]
        Schools,
        [EnumMember(Value = "screen_name")]
        ScreenName,
        [EnumMember(Value = "sex")]
        Sex,
        [EnumMember(Value = "site")]
        Site,
        [EnumMember(Value = "start_date")]
        StartDate,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "timezone")]
        Timezone,
        [EnumMember(Value = "trending")]
        Trending,
        [EnumMember(Value = "tv")]
        Tv,
        [EnumMember(Value = "type")]
        Type,
        [EnumMember(Value = "universities")]
        Universities,
        [EnumMember(Value = "verified")]
        Verified,
        [EnumMember(Value = "wall_comments")]
        WallComments,
        [EnumMember(Value = "wiki_page")]
        WikiPage,
        [EnumMember(Value = "vk_admin_status")]
        VkAdminStatus
    }
}