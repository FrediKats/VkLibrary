using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Converters;
using VkLib.Types.Base;

namespace VkLib.Types.Groups
{
    public class GroupFull : Group
    {
        /// <summary>
        ///     Information whether current user is subscribed
        /// </summary>
        [JsonProperty("is_subscribed")]
        public int? IsSubscribed { get; set; }

        /// <summary>
        ///     Information whether current user can post on community's wall
        /// </summary>
        [JsonProperty("can_post")]
        public int? CanPost { get; set; }

        /// <summary>
        ///     Start date of event in Unixtime
        /// </summary>
        [JsonProperty("start_date")]
        public int? StartDate { get; set; }

        /// <summary>
        ///     Information whether age limit
        /// </summary>
        [JsonProperty("age_limits")]
        public int? AgeLimits { get; set; }

        /// <summary>
        ///     Main section of community
        /// </summary>
        [JsonProperty("main_section")]
        public int? MainSection { get; set; }

        /// <summary>
        ///     Information whether current user can send a message to community
        /// </summary>
        [JsonProperty("is_messages_allowed")]
        public int? IsMessagesAllowed { get; set; }

        /// <summary>
        ///     Community's main photo album ID
        /// </summary>
        [JsonProperty("main_album_id")]
        public int? MainAlbumId { get; set; }

        /// <summary>
        ///     Finish date of event in Unixtime
        /// </summary>
        [JsonProperty("finish_date")]
        public int? FinishDate { get; set; }

        /// <summary>
        ///     Information whether current user can upload video
        /// </summary>
        [JsonProperty("can_upload_video")]
        public int? CanUploadVideo { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("city")]
        public Object City { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("contacts")]
        public IEnumerable<ContactsItem> Contacts { get; set; }

        /// <summary>
        ///     Community's main wiki page title
        /// </summary>
        [JsonProperty("wiki_page")]
        public string WikiPage { get; set; }

        /// <summary>
        ///     Community status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Information whether current user can send a message to community
        /// </summary>
        [JsonProperty("can_message")]
        public int? CanMessage { get; set; }

        /// <summary>
        ///     Information whether current user can see all posts on community's wall
        /// </summary>
        [JsonProperty("can_see_all_posts")]
        public int? CanSeeAllPosts { get; set; }

        /// <summary>
        ///     Community members number
        /// </summary>
        [JsonProperty("members_count")]
        public int? MembersCount { get; set; }

        /// <summary>
        ///     Type of group, start date of event or category of public page
        /// </summary>
        [JsonProperty("activity")]
        public string Activity { get; set; }

        /// <summary>
        ///     Information whether community is verified
        /// </summary>
        [JsonProperty("verified")]
        public int? Verified { get; set; }

        /// <summary>
        ///     Current user's member status
        /// </summary>
        [JsonProperty("member_status")]
        public int? MemberStatus { get; set; }

        /// <summary>
        ///     Information whether community is banned
        /// </summary>
        [JsonProperty("deactivated")]
        public string Deactivated { get; set; }

        /// <summary>
        ///     Fixed post ID
        /// </summary>
        [JsonProperty("fixed_post")]
        public int? FixedPost { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("counters")]
        [JsonConverter(typeof(InvalidTypeJsonConverter))]
        public CountersGroup Counters { get; set; }

        /// <summary>
        ///     Community's website
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        ///     Community description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Information whether current user can create topic
        /// </summary>
        [JsonProperty("can_create_topic")]
        public int? CanCreateTopic { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("links")]
        public IEnumerable<LinksItem> Links { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("market")]
        public MarketInfo Market { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("country")]
        public Country Country { get; set; }

        /// <summary>
        ///     Information whether community is in faves
        /// </summary>
        [JsonProperty("is_favorite")]
        public int? IsFavorite { get; set; }
    }
}