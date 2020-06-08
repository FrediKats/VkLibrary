using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GroupsGroupFull : GroupsGroup
    {
        [JsonProperty("market")]
        public GroupsMarketInfo Market { get; set; }

        ///<summary>
        /// Current user's member status
        ///</summary>
        [JsonProperty("member_status")]
        public GroupsGroupFullMemberStatus MemberStatus { get; set; }

        ///<summary>
        /// Information whether community is adult
        ///</summary>
        [JsonProperty("is_adult")]
        public int IsAdult { get; set; }

        ///<summary>
        /// Information whether community is hidden from current user's newsfeed
        ///</summary>
        [JsonProperty("is_hidden_from_feed")]
        public int IsHiddenFromFeed { get; set; }

        ///<summary>
        /// Information whether community is in faves
        ///</summary>
        [JsonProperty("is_favorite")]
        public int IsFavorite { get; set; }

        ///<summary>
        /// Information whether current user is subscribed
        ///</summary>
        [JsonProperty("is_subscribed")]
        public int IsSubscribed { get; set; }
        [JsonProperty("city")]
        public BaseObject City { get; set; }
        [JsonProperty("country")]
        public BaseCountry Country { get; set; }

        ///<summary>
        /// Information whether community is verified
        ///</summary>
        [JsonProperty("verified")]
        public int Verified { get; set; }

        ///<summary>
        /// Community description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// Community's main wiki page title
        ///</summary>
        [JsonProperty("wiki_page")]
        public String WikiPage { get; set; }

        ///<summary>
        /// Community members number
        ///</summary>
        [JsonProperty("members_count")]
        public int MembersCount { get; set; }
        [JsonProperty("counters")]
        public GroupsCountersGroup Counters { get; set; }
        [JsonProperty("cover")]
        public GroupsCover Cover { get; set; }

        ///<summary>
        /// Information whether current user can post on community's wall
        ///</summary>
        [JsonProperty("can_post")]
        public int CanPost { get; set; }

        ///<summary>
        /// Information whether current user can see all posts on community's wall
        ///</summary>
        [JsonProperty("can_see_all_posts")]
        public int CanSeeAllPosts { get; set; }

        ///<summary>
        /// Type of group, start date of event or category of public page
        ///</summary>
        [JsonProperty("activity")]
        public String Activity { get; set; }

        ///<summary>
        /// Fixed post ID
        ///</summary>
        [JsonProperty("fixed_post")]
        public int FixedPost { get; set; }

        ///<summary>
        /// Information whether current user can create topic
        ///</summary>
        [JsonProperty("can_create_topic")]
        public int CanCreateTopic { get; set; }

        ///<summary>
        /// Information whether current user can upload doc
        ///</summary>
        [JsonProperty("can_upload_doc")]
        public int CanUploadDoc { get; set; }

        ///<summary>
        /// Information whether current user can upload story
        ///</summary>
        [JsonProperty("can_upload_story")]
        public int CanUploadStory { get; set; }

        ///<summary>
        /// Information whether current user can upload video
        ///</summary>
        [JsonProperty("can_upload_video")]
        public int CanUploadVideo { get; set; }

        ///<summary>
        /// Information whether community has photo
        ///</summary>
        [JsonProperty("has_photo")]
        public int HasPhoto { get; set; }

        ///<summary>
        /// Community status
        ///</summary>
        [JsonProperty("status")]
        public String Status { get; set; }

        ///<summary>
        /// Community's main photo album ID
        ///</summary>
        [JsonProperty("main_album_id")]
        public int MainAlbumId { get; set; }
        [JsonProperty("links")]
        public GroupsLinksItem[] Links { get; set; }
        [JsonProperty("contacts")]
        public GroupsContactsItem[] Contacts { get; set; }

        ///<summary>
        /// Information about wall status in community
        ///</summary>
        [JsonProperty("wall")]
        public int Wall { get; set; }

        ///<summary>
        /// Community's website
        ///</summary>
        [JsonProperty("site")]
        public String Site { get; set; }
        [JsonProperty("main_section")]
        public GroupsGroupFullMainSection MainSection { get; set; }

        ///<summary>
        /// Information whether the community has a "fire" pictogram.
        ///</summary>
        [JsonProperty("trending")]
        public int Trending { get; set; }

        ///<summary>
        /// Information whether current user can send a message to community
        ///</summary>
        [JsonProperty("can_message")]
        public int CanMessage { get; set; }

        ///<summary>
        /// Information whether community can send a message to current user
        ///</summary>
        [JsonProperty("is_messages_blocked")]
        public int IsMessagesBlocked { get; set; }

        ///<summary>
        /// Information whether community can send notifications by phone number to current user
        ///</summary>
        [JsonProperty("can_send_notify")]
        public int CanSendNotify { get; set; }

        ///<summary>
        /// Status of replies in community messages
        ///</summary>
        [JsonProperty("online_status")]
        public GroupsOnlineStatus OnlineStatus { get; set; }

        ///<summary>
        /// Information whether age limit
        ///</summary>
        [JsonProperty("age_limits")]
        public GroupsGroupFullAgeLimits AgeLimits { get; set; }

        ///<summary>
        /// User ban info
        ///</summary>
        [JsonProperty("ban_info")]
        public GroupsGroupBanInfo BanInfo { get; set; }

        ///<summary>
        /// Information whether community has installed market app
        ///</summary>
        [JsonProperty("has_market_app")]
        public Boolean HasMarketApp { get; set; }

        ///<summary>
        /// Info about addresses in groups
        ///</summary>
        [JsonProperty("addresses")]
        public GroupsAddressesInfo Addresses { get; set; }

        ///<summary>
        /// Information whether current user is subscribed to podcasts
        ///</summary>
        [JsonProperty("is_subscribed_podcasts")]
        public Boolean IsSubscribedPodcasts { get; set; }

        ///<summary>
        /// Owner in whitelist or not
        ///</summary>
        [JsonProperty("can_subscribe_podcasts")]
        public Boolean CanSubscribePodcasts { get; set; }

        ///<summary>
        /// Can subscribe to wall
        ///</summary>
        [JsonProperty("can_subscribe_posts")]
        public Boolean CanSubscribePosts { get; set; }
    }
}