using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
{
    public enum UsersFields
    {
        [EnumMember(Value = "photo_id")]
        PhotoId,
        [EnumMember(Value = "verified")]
        Verified,
        [EnumMember(Value = "sex")]
        Sex,
        [EnumMember(Value = "bdate")]
        Bdate,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "country")]
        Country,
        [EnumMember(Value = "home_town")]
        HomeTown,
        [EnumMember(Value = "has_photo")]
        HasPhoto,
        [EnumMember(Value = "photo_50")]
        Photo50,
        [EnumMember(Value = "photo_100")]
        Photo100,
        [EnumMember(Value = "photo_200_orig")]
        Photo200Orig,
        [EnumMember(Value = "photo_200")]
        Photo200,
        [EnumMember(Value = "photo_400_orig")]
        Photo400Orig,
        [EnumMember(Value = "photo_max")]
        PhotoMax,
        [EnumMember(Value = "photo_max_orig")]
        PhotoMaxOrig,
        [EnumMember(Value = "online")]
        Online,
        [EnumMember(Value = "lists")]
        Lists,
        [EnumMember(Value = "domain")]
        Domain,
        [EnumMember(Value = "has_mobile")]
        HasMobile,
        [EnumMember(Value = "contacts")]
        Contacts,
        [EnumMember(Value = "site")]
        Site,
        [EnumMember(Value = "education")]
        Education,
        [EnumMember(Value = "universities")]
        Universities,
        [EnumMember(Value = "schools")]
        Schools,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "last_seen")]
        LastSeen,
        [EnumMember(Value = "followers_count")]
        FollowersCount,
        [EnumMember(Value = "counters")]
        Counters,
        [EnumMember(Value = "common_count")]
        CommonCount,
        [EnumMember(Value = "occupation")]
        Occupation,
        [EnumMember(Value = "nickname")]
        Nickname,
        [EnumMember(Value = "relatives")]
        Relatives,
        [EnumMember(Value = "relation")]
        Relation,
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "connections")]
        Connections,
        [EnumMember(Value = "exports")]
        Exports,
        [EnumMember(Value = "wall_comments")]
        WallComments,
        [EnumMember(Value = "activities")]
        Activities,
        [EnumMember(Value = "interests")]
        Interests,
        [EnumMember(Value = "music")]
        Music,
        [EnumMember(Value = "movies")]
        Movies,
        [EnumMember(Value = "tv")]
        Tv,
        [EnumMember(Value = "books")]
        Books,
        [EnumMember(Value = "games")]
        Games,
        [EnumMember(Value = "about")]
        About,
        [EnumMember(Value = "quotes")]
        Quotes,
        [EnumMember(Value = "can_post")]
        CanPost,
        [EnumMember(Value = "can_see_all_posts")]
        CanSeeAllPosts,
        [EnumMember(Value = "can_see_audio")]
        CanSeeAudio,
        [EnumMember(Value = "can_write_private_message")]
        CanWritePrivateMessage,
        [EnumMember(Value = "can_send_friend_request")]
        CanSendFriendRequest,
        [EnumMember(Value = "is_favorite")]
        IsFavorite,
        [EnumMember(Value = "is_hidden_from_feed")]
        IsHiddenFromFeed,
        [EnumMember(Value = "timezone")]
        Timezone,
        [EnumMember(Value = "screen_name")]
        ScreenName,
        [EnumMember(Value = "maiden_name")]
        MaidenName,
        [EnumMember(Value = "crop_photo")]
        CropPhoto,
        [EnumMember(Value = "is_friend")]
        IsFriend,
        [EnumMember(Value = "friend_status")]
        FriendStatus,
        [EnumMember(Value = "career")]
        Career,
        [EnumMember(Value = "military")]
        Military,
        [EnumMember(Value = "blacklisted")]
        Blacklisted,
        [EnumMember(Value = "blacklisted_by_me")]
        BlacklistedByMe,
        [EnumMember(Value = "can_subscribe_posts")]
        CanSubscribePosts,
        [EnumMember(Value = "descriptions")]
        Descriptions,
        [EnumMember(Value = "trending")]
        Trending,
        [EnumMember(Value = "mutual")]
        Mutual
    }
}