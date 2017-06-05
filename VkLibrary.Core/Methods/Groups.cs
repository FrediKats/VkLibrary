using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Groups;
using VkLibrary.Core.Types.Groups;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Groups API section.
    /// </summary>
    public class Groups
    {
        private readonly Vkontakte _vkontakte;

        internal Groups(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// Docs: <see href="https://vk.com/dev/groups.isMember">groups.isMember</see>
        /// </summary>
        /// <param name="groupId">ID or screen name of the community.</param>
        /// <param name="userId">User ID.</param>
        /// <param name="userIds">User IDs.</param>
        public async Task<int> IsMember(string groupId = null, int? userId = null, IEnumerable<int?> userIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId);
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            parameters.Add("extended", false.ToApiString());

            return await _vkontakte.GetAsync<int>("groups.isMember", parameters);
        }

        /// <summary>
        /// Returns information about communities by their IDs.
        /// Docs: <see href="https://vk.com/dev/groups.getById">groups.getById</see>
        /// </summary>
        /// <param name="groupIds">IDs or screen names of communities.</param>
        /// <param name="groupId">ID or screen name of the community.</param>
        /// <param name="fields">Group fields to return.;</param>
        public async Task<IEnumerable<GroupFull>> GetById(IEnumerable<string> groupIds = null, string groupId = null,
            IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupIds != null)
                parameters.Add("group_ids", groupIds.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId);
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<GroupFull>>("groups.getById", parameters);
        }

        /// <summary>
        /// Returns a list of the communities to which a user belongs.; ;
        /// Docs: <see href="https://vk.com/dev/groups.get">groups.get</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="extended">
        /// '1' — to return complete information about a user's communities; '0' — to return a list of
        /// community IDs without any additional fields (default);
        /// </param>
        /// <param name="filter">
        /// Types of communities to return:; 'admin' — to return communities administered by the user ;
        /// 'editor' — to return communities where the user is an administrator or editor; 'moder' — to return communities
        /// where the user is an administrator, editor, or moderator; 'groups' — to return only groups; 'publics' — to return
        /// only public pages; 'events' — to return only events
        /// </param>
        /// <param name="fields">Profile fields to return.;</param>
        /// <param name="offset">Offset needed to return a specific subset of communities.</param>
        /// <param name="count">Number of communities to return.</param>
        public async Task<ApiItemsResponse<GroupFull>> Get(int? userId = null, bool? extended = true,
            IEnumerable<string> filter = null, IEnumerable<string> fields = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (filter != null)
                parameters.Add("filter", filter.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<GroupFull>>("groups.get", parameters);
        }

        /// <summary>
        /// Returns a list of community members.
        /// Docs: <see href="https://vk.com/dev/groups.getMembers">groups.getMembers</see>
        /// </summary>
        /// <param name="groupId">ID or screen name of the community.</param>
        /// <param name="sort">
        /// Sort order. Available values: 'id_asc', 'id_desc', 'time_asc', 'time_desc'.; 'time_asc' and
        /// 'time_desc' are availavle only if the method is called by the group's 'moderator'.
        /// </param>
        /// <param name="offset">Offset needed to return a specific subset of community members.</param>
        /// <param name="count">Number of community members to return.</param>
        /// <param name="fields">
        /// List of additional fields to be returned. ; Available values: 'sex, bdate, city, country,
        /// photo_50, photo_100, photo_200_orig, photo_200, photo_400_orig, photo_max, photo_max_orig, online, online_mobile,
        /// lists, domain, has_mobile, contacts, connections, site, education, universities, schools, can_post,
        /// can_see_all_posts, can_see_audio, can_write_private_message, status, last_seen, common_count, relation, relatives,
        /// counters'.
        /// </param>
        /// <param name="filter">
        /// *'friends' – only friends in this community will be returned;; *'unsure' – only those who pressed
        /// 'I may attend' will be returned (if it's an event).
        /// </param>
        public async Task<ApiItemsResponse<T>> GetMembers<T>(int? groupId = null, string sort = null,
            int? offset = null, int? count = null, IEnumerable<string> fields = null, string filter = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort);
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (filter != null)
                parameters.Add("filter", filter);

            return await _vkontakte.GetAsync<ApiItemsResponse<T>>("groups.getMembers", parameters);
        }

        /// <summary>
        /// With this method you can join the group or public page, and also confirm your participation in an event.
        /// Docs: <see href="https://vk.com/dev/groups.join">groups.join</see>
        /// </summary>
        /// <param name="groupId">ID or screen name of the community.</param>
        /// <param name="notSure">
        /// Optional parameter which is taken into account when 'gid' belongs to the event:; '1' — Perhaps I
        /// will attend; '0' — I will be there for sure (default); ;
        /// </param>
        public async Task<int> Join(int? groupId = null, string notSure = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (notSure != null)
                parameters.Add("not_sure", notSure);

            return await _vkontakte.GetAsync<int>("groups.join", parameters);
        }

        /// <summary>
        /// With this method you can leave a group, public page, or event.; ;
        /// Docs: <see href="https://vk.com/dev/groups.leave">groups.leave</see>
        /// </summary>
        /// <param name="groupId">ID or screen name of the community.</param>
        public async Task<int> Leave(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return await _vkontakte.GetAsync<int>("groups.leave", parameters);
        }

        /// <summary>
        /// Returns a list of communities matching the search criteria.
        /// Docs: <see href="https://vk.com/dev/groups.search">groups.search</see>
        /// </summary>
        /// <param name="q">Search query string.</param>
        /// <param name="type">Community type. Possible values: 'group, page, event.'</param>
        /// <param name="countryId">Country ID.</param>
        /// <param name="cityId">City ID. If this parameter is transmitted, country_id is ignored.</param>
        /// <param name="future">'1' — to return only upcoming events. Works with the 'type' = 'event' only.</param>
        /// <param name="market">'1' — to return communities with enabled market only.</param>
        /// <param name="sort">
        /// Sort order. Possible values:; *'0' — default sorting (similar the full version of the site);; *'1' —
        /// by growth speed;; *'2'— by the "day attendance/members number" ratio;; *'3' — by the "Likes number/members number"
        /// ratio;; *'4' — by the "comments number/members number" ratio;; *'5' — by the "boards entries number/members number"
        /// ratio.; ;
        /// </param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">
        /// Number of communities to return.; "Note that you can not receive more than first thousand of
        /// results, regardless of 'count' and 'offset' values."
        /// </param>
        public async Task<ApiItemsResponse<Group>> Search(string q = null, string type = null, int? countryId = null,
            int? cityId = null, bool? future = null, bool? market = null, int? sort = null, int? offset = null,
            int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (type != null)
                parameters.Add("type", type);
            if (countryId != null)
                parameters.Add("country_id", countryId.ToApiString());
            if (cityId != null)
                parameters.Add("city_id", cityId.ToApiString());
            if (future != null)
                parameters.Add("future", future.ToApiString());
            if (market != null)
                parameters.Add("market", market.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<Group>>("groups.search", parameters);
        }

        /// <summary>
        /// Returns communities list for a catalog category.
        /// Docs: <see href="https://vk.com/dev/groups.getCatalog">groups.getCatalog</see>
        /// </summary>
        /// <param name="categoryId">Category id received from [vk.com/dev/groups.getCatalogInfo|groups.getCatalogInfo].</param>
        /// <param name="subcategoryId">Subcategory id received from [vk.com/dev/groups.getCatalogInfo|groups.getCatalogInfo].</param>
        public async Task<ApiItemsResponse<Group>> GetCatalog(int? categoryId = null, int? subcategoryId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (categoryId != null)
                parameters.Add("category_id", categoryId.ToApiString());
            if (subcategoryId != null)
                parameters.Add("subcategory_id", subcategoryId.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<Group>>("groups.getCatalog", parameters);
        }

        /// <summary>
        /// Returns categories list for communities catalog
        /// Docs: <see href="https://vk.com/dev/groups.getCatalogInfo">groups.getCatalogInfo</see>
        /// </summary>
        /// <param name="extended">1 – to return communities count and three communities for preview.; By default: 0.</param>
        /// <param name="subcategories">1 – to return subcategories info.; By default: 0.</param>
        public async Task<GetCatalogInfoResponse> GetCatalogInfo(bool? extended = null, bool? subcategories = null)
        {
            var parameters = new Dictionary<string, string>();

            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (subcategories != null)
                parameters.Add("subcategories", subcategories.ToApiString());

            return await _vkontakte.GetAsync<GetCatalogInfoResponse>("groups.getCatalogInfo", parameters);
        }

        /// <summary>
        /// Returns a list of invitations to join communities and events.; ;
        /// Docs: <see href="https://vk.com/dev/groups.getInvites">groups.getInvites</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of invitations.</param>
        /// <param name="count">Number of invitations to return.</param>
        /// <param name="extended">'1' — to return additional [vk.com/dev/fields_groups|fields] for communities..</param>
        public async Task<ApiItemsResponse<GroupXtrInvitedBy>> GetInvites(int? offset = null, int? count = null,
            bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<GroupXtrInvitedBy>>("groups.getInvites", parameters);
        }

        /// <summary>
        /// Returns invited users list of a community
        /// Docs: <see href="https://vk.com/dev/groups.getInvitedUsers">groups.getInvitedUsers</see>
        /// </summary>
        /// <param name="groupId">Group ID to return invited users for.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of results to return.</param>
        /// <param name="fields">
        /// List of additional fields to be returned. ; Available values: 'sex, bdate, city, country,
        /// photo_50, photo_100, photo_200_orig, photo_200, photo_400_orig, photo_max, photo_max_orig, online, online_mobile,
        /// lists, domain, has_mobile, contacts, connections, site, education, universities, schools, can_post,
        /// can_see_all_posts, can_see_audio, can_write_private_message, status, last_seen, common_count, relation, relatives,
        /// counters'.
        /// </param>
        /// <param name="nameCase">
        /// Case for declension of user name and surname. Possible values:; *'nom' — nominative (default);;
        /// *'gen' — genitive;; *'dat' — dative;; *'acc' — accusative; ; *'ins' — instrumental;; *'abl' — prepositional.
        /// </param>
        public async Task<ApiItemsResponse<UserFull>> GetInvitedUsers(int? groupId = null, int? offset = null,
            int? count = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase);

            return await _vkontakte.GetAsync<ApiItemsResponse<UserFull>>("groups.getInvitedUsers", parameters);
        }

        /// <summary>
        /// Adds a user to a community blacklist.
        /// Docs: <see href="https://vk.com/dev/groups.banUser">groups.banUser</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="userId">User ID.</param>
        /// <param name="endDate">Date (in Unix time) when the user will be removed from the blacklist.</param>
        /// <param name="reason">
        /// Reason for ban:; '1' — spam; '2' — verbal abuse; '3' — strong language; '4' — irrelevant messages;
        /// '0' — other (default)
        /// </param>
        /// <param name="comment">Text of comment to ban.</param>
        /// <param name="commentVisible">
        /// '1' — text of comment will be visible to the user;; '0' — text of comment will be
        /// invisible to the user. ; By default: '0'.
        /// </param>
        public async Task<int> BanUser(int? groupId = null, int? userId = null, int? endDate = null,
            int? reason = null, string comment = null, bool? commentVisible = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (endDate != null)
                parameters.Add("end_date", endDate.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());
            if (comment != null)
                parameters.Add("comment", comment);
            if (commentVisible != null)
                parameters.Add("comment_visible", commentVisible.ToApiString());

            return await _vkontakte.GetAsync<int>("groups.banUser", parameters);
        }

        /// <summary>
        /// Removes a user from a community blacklist.
        /// Docs: <see href="https://vk.com/dev/groups.unbanUser">groups.unbanUser</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="userId">User ID.</param>
        public async Task<int> UnbanUser(int? groupId = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<int>("groups.unbanUser", parameters);
        }

        /// <summary>
        /// Returns a list of users on a community blacklist.
        /// Docs: <see href="https://vk.com/dev/groups.getBanned">groups.getBanned</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of users.</param>
        /// <param name="count">Number of users to return.</param>
        /// <param name="fields"></param>
        /// <param name="userId"></param>
        public async Task<ApiItemsResponse<UserXtrBanInfo>> GetBanned(int? groupId = null, int? offset = null,
            int? count = null, IEnumerable<string> fields = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<UserXtrBanInfo>>("groups.getBanned", parameters);
        }

        /// <summary>
        /// Creates a new community.
        /// Docs: <see href="https://vk.com/dev/groups.create">groups.create</see>
        /// </summary>
        /// <param name="title">Community title.</param>
        /// <param name="description">Community description (ignored for 'type' = 'public').</param>
        /// <param name="type">Community type. Possible values:; *'group' – group;; *'event' – event;; *'public' – public page</param>
        /// <param name="publicCategory">Category ID (for 'type' = 'public' only).</param>
        /// <param name="subtype">
        /// Public page subtype. Possible values:; *'1' – place or small business;; *'2' – company,
        /// organization or website;; *'3' – famous person or group of people;; *'4' – product or work of art.
        /// </param>
        public async Task<Group> Create(string title = null, string description = null, string type = null,
            int? publicCategory = null, int? subtype = null)
        {
            var parameters = new Dictionary<string, string>();

            if (title != null)
                parameters.Add("title", title);
            if (description != null)
                parameters.Add("description", description);
            if (type != null)
                parameters.Add("type", type);
            if (publicCategory != null)
                parameters.Add("public_category", publicCategory.ToApiString());
            if (subtype != null)
                parameters.Add("subtype", subtype.ToApiString());

            return await _vkontakte.GetAsync<Group>("groups.create", parameters);
        }

        /// <summary>
        /// Edits a community.
        /// Docs: <see href="https://vk.com/dev/groups.edit">groups.edit</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="title">Community title.</param>
        /// <param name="description">Community description.</param>
        /// <param name="screenName">Community screen name.</param>
        /// <param name="access">Community type. Possible values:; *'0' – open;; *'1' – closed;; *'2' – private.</param>
        /// <param name="website">Website that will be displayed in the community information field.</param>
        /// <param name="subject">
        /// Community subject. Possible values: ; *'1' – auto/moto;; *'2' – activity holidays;; *'3' –
        /// business;; *'4' – pets;; *'5' – health;; *'6' – dating and communication; ; *'7' – games;; *'8' – IT (computers and
        /// software);; *'9' – cinema;; *'10' – beauty and fashion;; *'11' – cooking;; *'12' – art and culture;; *'13' –
        /// literature;; *'14' – mobile services and internet;; *'15' – music;; *'16' – science and technology;; *'17' – real
        /// estate;; *'18' – news and media;; *'19' – security;; *'20' – education;; *'21' – home and renovations;; *'22' –
        /// politics;; *'23' – food;; *'24' – industry;; *'25' – travel;; *'26' – work;; *'27' – entertainment;; *'28' –
        /// religion;; *'29' – family;; *'30' – sports;; *'31' – insurance;; *'32' – television;; *'33' – goods and services;;
        /// *'34' – hobbies;; *'35' – finance;; *'36' – photo;; *'37' – esoterics;; *'38' – electronics and appliances;; *'39'
        /// – erotic;; *'40' – humor;; *'41' – society, humanities;; *'42' – design and graphics.
        /// </param>
        /// <param name="email">Organizer email (for events).</param>
        /// <param name="phone">Organizer phone number (for events).</param>
        /// <param name="rss">
        /// RSS feed address for import (available only to communities with special permission. Contact
        /// vk.com/support to get it.
        /// </param>
        /// <param name="eventStartDate">Event start date in Unixtime format.</param>
        /// <param name="eventFinishDate">Event finish date in Unixtime format.</param>
        /// <param name="eventGroupId">Organizer community ID (for events only).</param>
        /// <param name="publicCategory">Public page category ID.</param>
        /// <param name="publicSubcategory">Public page subcategory ID.</param>
        /// <param name="publicDate">Founding date of a company or organization owning the community in "dd.mm.YYYY" format.</param>
        /// <param name="wall">
        /// Wall settings. Possible values:; *'0' – disabled;; *'1' – open;; *'2' – limited (groups and events
        /// only);; *'3' – closed (groups and events only).;
        /// </param>
        /// <param name="topics">
        /// Board topics settings. Possbile values: ; *'0' – disabled;; *'1' – open;; *'2' – limited (for
        /// groups and events only).;
        /// </param>
        /// <param name="photos">
        /// Photos settings. Possible values:; *'0' – disabled;; *'1' – open;; *'2' – limited (for groups and
        /// events only).;
        /// </param>
        /// <param name="video">
        /// Video settings. Possible values:; *'0' – disabled;; *'1' – open;; *'2' – limited (for groups and
        /// events only).
        /// </param>
        /// <param name="audio">
        /// Audio settings. Possible values:; *'0' – disabled;; *'1' – open;; *'2' – limited (for groups and
        /// events only).
        /// </param>
        /// <param name="links">Links settings (for public pages only). Possible values:; *'0' – disabled;; *'1' – enabled.;</param>
        /// <param name="events">Events settings (for public pages only). Possible values:; *'0' – disabled;; *'1' – enabled.;</param>
        /// <param name="places">Places settings (for public pages only). Possible values:; *'0' – disabled;; *'1' – enabled.;</param>
        /// <param name="contacts">Contacts settings (for public pages only). Possible values:; *'0' – disabled;; *'1' – enabled.;</param>
        /// <param name="docs">
        /// Documents settings. Possible values:; *'0' – disabled;; *'1' – open;; *'2' – limited (for groups and
        /// events only).
        /// </param>
        /// <param name="wiki">
        /// Wiki pages settings. Possible values:; *'0' – disabled;; *'1' – open;; *'2' – limited (for groups
        /// and events only).
        /// </param>
        /// <param name="messages">Community messages. Possible values:; *'0' — disabled;; *'1' — enabled.</param>
        /// <param name="ageLimits">Community age limits. Possible values:; *'1' — no limits;; *'2' — 16+;; *'3' — 18+.</param>
        /// <param name="market">Market settings. Possible values:; *'0' – disabled;; *'1' – enabled.</param>
        /// <param name="marketComments">market comments settings. Possible values:; *'0' – disabled;; *'1' – enabled.</param>
        /// <param name="marketCountry">Market delivery countries.</param>
        /// <param name="marketCity">Market delivery cities (if only one country is specified).</param>
        /// <param name="marketCurrency">
        /// Market currency settings. Possbile values: ; *'643' – Russian rubles;; *'980' – Ukrainian
        /// hryvnia;; *'398' – Kazakh tenge;; *'978' – Euro;; *'840' – US dollars
        /// </param>
        /// <param name="marketContact">Seller contact for market.; Set '0' for community messages.</param>
        /// <param name="marketWiki">ID of a wiki page with market description.</param>
        /// <param name="obsceneFilter">
        /// Obscene expressions filter in comments. Possible values: ; *'0' – disabled;; *'1' –
        /// enabled.
        /// </param>
        /// <param name="obsceneStopwords">Stopwords filter in comments. Possible values: ; *'0' – disabled;; *'1' – enabled.</param>
        /// <param name="obsceneWords">Keywords for stopwords filter.</param>
        public async Task<int> Edit(int? groupId = null, string title = null, string description = null,
            string screenName = null, int? access = null, string website = null, string subject = null,
            string email = null, string phone = null, string rss = null, int? eventStartDate = null,
            int? eventFinishDate = null, int? eventGroupId = null, int? publicCategory = null,
            int? publicSubcategory = null, string publicDate = null, int? wall = null, int? topics = null,
            int? photos = null, int? video = null, int? audio = null, bool? links = null, bool? events = null,
            bool? places = null, bool? contacts = null, int? docs = null, int? wiki = null, bool? messages = null,
            int? ageLimits = null, bool? market = null, bool? marketComments = null,
            IEnumerable<int?> marketCountry = null, IEnumerable<int?> marketCity = null, int? marketCurrency = null,
            int? marketContact = null, int? marketWiki = null, bool? obsceneFilter = null,
            bool? obsceneStopwords = null, IEnumerable<string> obsceneWords = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (description != null)
                parameters.Add("description", description);
            if (screenName != null)
                parameters.Add("screen_name", screenName);
            if (access != null)
                parameters.Add("access", access.ToApiString());
            if (website != null)
                parameters.Add("website", website);
            if (subject != null)
                parameters.Add("subject", subject);
            if (email != null)
                parameters.Add("email", email);
            if (phone != null)
                parameters.Add("phone", phone);
            if (rss != null)
                parameters.Add("rss", rss);
            if (eventStartDate != null)
                parameters.Add("event_start_date", eventStartDate.ToApiString());
            if (eventFinishDate != null)
                parameters.Add("event_finish_date", eventFinishDate.ToApiString());
            if (eventGroupId != null)
                parameters.Add("event_group_id", eventGroupId.ToApiString());
            if (publicCategory != null)
                parameters.Add("public_category", publicCategory.ToApiString());
            if (publicSubcategory != null)
                parameters.Add("public_subcategory", publicSubcategory.ToApiString());
            if (publicDate != null)
                parameters.Add("public_date", publicDate);
            if (wall != null)
                parameters.Add("wall", wall.ToApiString());
            if (topics != null)
                parameters.Add("topics", topics.ToApiString());
            if (photos != null)
                parameters.Add("photos", photos.ToApiString());
            if (video != null)
                parameters.Add("video", video.ToApiString());
            if (audio != null)
                parameters.Add("audio", audio.ToApiString());
            if (links != null)
                parameters.Add("links", links.ToApiString());
            if (events != null)
                parameters.Add("events", events.ToApiString());
            if (places != null)
                parameters.Add("places", places.ToApiString());
            if (contacts != null)
                parameters.Add("contacts", contacts.ToApiString());
            if (docs != null)
                parameters.Add("docs", docs.ToApiString());
            if (wiki != null)
                parameters.Add("wiki", wiki.ToApiString());
            if (messages != null)
                parameters.Add("messages", messages.ToApiString());
            if (ageLimits != null)
                parameters.Add("age_limits", ageLimits.ToApiString());
            if (market != null)
                parameters.Add("market", market.ToApiString());
            if (marketComments != null)
                parameters.Add("market_comments", marketComments.ToApiString());
            if (marketCountry != null)
                parameters.Add("market_country", marketCountry.ToApiString());
            if (marketCity != null)
                parameters.Add("market_city", marketCity.ToApiString());
            if (marketCurrency != null)
                parameters.Add("market_currency", marketCurrency.ToApiString());
            if (marketContact != null)
                parameters.Add("market_contact", marketContact.ToApiString());
            if (marketWiki != null)
                parameters.Add("market_wiki", marketWiki.ToApiString());
            if (obsceneFilter != null)
                parameters.Add("obscene_filter", obsceneFilter.ToApiString());
            if (obsceneStopwords != null)
                parameters.Add("obscene_stopwords", obsceneStopwords.ToApiString());
            if (obsceneWords != null)
                parameters.Add("obscene_words", obsceneWords.ToApiString());

            return await _vkontakte.GetAsync<int>("groups.edit", parameters);
        }

        /// <summary>
        /// Edits the place in community.
        /// Docs: <see href="https://vk.com/dev/groups.editPlace">groups.editPlace</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="title">Place title.</param>
        /// <param name="address">Place address.</param>
        /// <param name="countryId">Country ID.</param>
        /// <param name="cityId">City ID.</param>
        /// <param name="latitude">Geographical latitude.</param>
        /// <param name="longitude">Geographical longitude.</param>
        public async Task<EditPlaceResponse> EditPlace(int? groupId = null, string title = null, string address = null,
            int? countryId = null, int? cityId = null, uint? latitude = null, uint? longitude = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (address != null)
                parameters.Add("address", address);
            if (countryId != null)
                parameters.Add("country_id", countryId.ToApiString());
            if (cityId != null)
                parameters.Add("city_id", cityId.ToApiString());
            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());

            return await _vkontakte.GetAsync<EditPlaceResponse>("groups.editPlace", parameters);
        }

        /// <summary>
        /// Returns community settings.
        /// Docs: <see href="https://vk.com/dev/groups.getSettings">groups.getSettings</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        public async Task<GroupSettings> GetSettings(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return await _vkontakte.GetAsync<GroupSettings>("groups.getSettings", parameters);
        }

        /// <summary>
        /// Returns a list of requests to the community.
        /// Docs: <see href="https://vk.com/dev/groups.getRequests">groups.getRequests</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of results to return.</param>
        /// <param name="fields">Profile fields to return.;</param>
        public async Task<ApiItemsResponse<int?>> GetRequests(int? groupId = null, int? offset = null,
            int? count = null, IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<int?>>("groups.getRequests", parameters);
        }

        /// <summary>
        /// Allows to add, remove or edit the community manager.
        /// Docs: <see href="https://vk.com/dev/groups.editManager">groups.editManager</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="userId">User ID.</param>
        /// <param name="role">Manager role. Possible values:; *'moderator';; *'editor';; *'administrator'.</param>
        /// <param name="isContact">'1' — to show the manager in Contacts block of the community.</param>
        /// <param name="contactPosition">Position to show in Contacts block.</param>
        /// <param name="contactPhone">Contact phone.</param>
        /// <param name="contactEmail">Contact e-mail.</param>
        public async Task<int> EditManager(int? groupId = null, int? userId = null, string role = null,
            bool? isContact = null, string contactPosition = null, string contactPhone = null,
            string contactEmail = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (role != null)
                parameters.Add("role", role);
            if (isContact != null)
                parameters.Add("is_contact", isContact.ToApiString());
            if (contactPosition != null)
                parameters.Add("contact_position", contactPosition);
            if (contactPhone != null)
                parameters.Add("contact_phone", contactPhone);
            if (contactEmail != null)
                parameters.Add("contact_email", contactEmail);

            return await _vkontakte.GetAsync<int>("groups.editManager", parameters);
        }

        /// <summary>
        /// Allows to invite friends to the community.
        /// Docs: <see href="https://vk.com/dev/groups.invite">groups.invite</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="userId">User ID.</param>
        public async Task<int> Invite(int? groupId = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<int>("groups.invite", parameters);
        }

        /// <summary>
        /// Allows to add a link to the community.
        /// Docs: <see href="https://vk.com/dev/groups.addLink">groups.addLink</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="link">Link URL.</param>
        /// <param name="text">Description text for the link.</param>
        public async Task<GroupLink> AddLink(int? groupId = null, string link = null, string text = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (link != null)
                parameters.Add("link", link);
            if (text != null)
                parameters.Add("text", text);

            return await _vkontakte.GetAsync<GroupLink>("groups.addLink", parameters);
        }

        /// <summary>
        /// Allows to delete a link from the community.
        /// Docs: <see href="https://vk.com/dev/groups.deleteLink">groups.deleteLink</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="linkId">Link ID.</param>
        public async Task<int> DeleteLink(int? groupId = null, int? linkId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (linkId != null)
                parameters.Add("link_id", linkId.ToApiString());

            return await _vkontakte.GetAsync<int>("groups.deleteLink", parameters);
        }

        /// <summary>
        /// Allows to edit a link in the community.
        /// Docs: <see href="https://vk.com/dev/groups.editLink">groups.editLink</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="linkId">Link ID.</param>
        /// <param name="text">New description text for the link.</param>
        public async Task<int> EditLink(int? groupId = null, int? linkId = null, string text = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (linkId != null)
                parameters.Add("link_id", linkId.ToApiString());
            if (text != null)
                parameters.Add("text", text);

            return await _vkontakte.GetAsync<int>("groups.editLink", parameters);
        }

        /// <summary>
        /// Allows to reorder links in the community.
        /// Docs: <see href="https://vk.com/dev/groups.reorderLink">groups.reorderLink</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="linkId">Link ID.</param>
        /// <param name="after">ID of the link after which to place the link with 'link_id'.</param>
        public async Task<int> ReorderLink(int? groupId = null, int? linkId = null, int? after = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (linkId != null)
                parameters.Add("link_id", linkId.ToApiString());
            if (after != null)
                parameters.Add("after", after.ToApiString());

            return await _vkontakte.GetAsync<int>("groups.reorderLink", parameters);
        }

        /// <summary>
        /// Removes a user from the community.
        /// Docs: <see href="https://vk.com/dev/groups.removeUser">groups.removeUser</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="userId">User ID.</param>
        public async Task<int> RemoveUser(int? groupId = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<int>("groups.removeUser", parameters);
        }

        /// <summary>
        /// Allows to approve join request to the community.
        /// Docs: <see href="https://vk.com/dev/groups.approveRequest">groups.approveRequest</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="userId">User ID.</param>
        public async Task<int> ApproveRequest(int? groupId = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<int>("groups.approveRequest", parameters);
        }

        /// <summary>
        /// Returns Callback API confirmation code for the community.
        /// Docs: <see href="https://vk.com/dev/groups.getCallbackConfirmationCode">groups.getCallbackConfirmationCode</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        public async Task<GetCallbackConfirmationCodeResponse> GetCallbackConfirmationCode(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return await _vkontakte.GetAsync<GetCallbackConfirmationCodeResponse>("groups.getCallbackConfirmationCode",
                parameters);
        }

        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] server settings for the community.
        /// Docs: <see href="https://vk.com/dev/groups.getCallbackServerSettings">groups.getCallbackServerSettings</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        public async Task<GetCallbackServerSettingsResponse> GetCallbackServerSettings(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return await _vkontakte.GetAsync<GetCallbackServerSettingsResponse>("groups.getCallbackServerSettings",
                parameters);
        }

        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] notifications settings.
        /// Docs: <see href="https://vk.com/dev/groups.getCallbackSettings">groups.getCallbackSettings</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        public async Task<GetCallbackSettingsResponse> GetCallbackSettings(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return await _vkontakte.GetAsync<GetCallbackSettingsResponse>("groups.getCallbackSettings", parameters);
        }

        /// <summary>
        /// Allow to set [vk.com/dev/callback_api|Callback API] server URL for the community. ; ;
        /// Docs: <see href="https://vk.com/dev/groups.setCallbackServer">groups.setCallbackServer</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="serverUrl">Server URL.</param>
        public async Task<SetCallbackServerResponse> SetCallbackServer(int? groupId = null, string serverUrl = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (serverUrl != null)
                parameters.Add("server_url", serverUrl);

            return await _vkontakte.GetAsync<SetCallbackServerResponse>("groups.setCallbackServer", parameters);
        }

        /// <summary>
        /// Allow to set [vk.com/dev/callback_api|Callback API] server settings.
        /// Docs: <see href="https://vk.com/dev/groups.setCallbackServerSettings">groups.setCallbackServerSettings</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="secretKey">Callback API secret key.</param>
        public async Task<int> SetCallbackServerSettings(int? groupId = null, string secretKey = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (secretKey != null)
                parameters.Add("secret_key", secretKey);

            return await _vkontakte.GetAsync<int>("groups.setCallbackServerSettings", parameters);
        }

        /// <summary>
        /// Allow to set notifications settings for group.
        /// Docs: <see href="https://vk.com/dev/groups.setCallbackSettings">groups.setCallbackSettings</see>
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="messageNew">New messages notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="messageAllow">Allowed messages notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="messageDeny">Denied messages notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="photoNew">New photos notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="audioNew">New audios notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="videoNew">New videos notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="wallReplyNew">New wall replies notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="wallReplyEdit">Wall replies edited notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="wallPostNew">New wall posts notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="boardPostNew">New board posts notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="boardPostEdit">Board posts edited notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="boardPostRestore">Board posts restored notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="boardPostDelete">Board posts deleted notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="photoCommentNew">New comment to photo notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="videoCommentNew">New comment to video notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="marketCommentNew">New comment to market item notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="groupJoin">Joined community notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="groupLeave">Left community notifications ('0' — disabled, '1' — enabled).</param>
        public async Task<int> SetCallbackSettings(int? groupId = null, bool? messageNew = null,
            bool? messageAllow = null, bool? messageDeny = null, bool? photoNew = null, bool? audioNew = null,
            bool? videoNew = null, bool? wallReplyNew = null, bool? wallReplyEdit = null,
            bool? wallPostNew = null, bool? boardPostNew = null, bool? boardPostEdit = null,
            bool? boardPostRestore = null, bool? boardPostDelete = null, bool? photoCommentNew = null,
            bool? videoCommentNew = null, bool? marketCommentNew = null, bool? groupJoin = null,
            bool? groupLeave = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (messageNew != null)
                parameters.Add("message_new", messageNew.ToApiString());
            if (messageAllow != null)
                parameters.Add("message_allow", messageAllow.ToApiString());
            if (messageDeny != null)
                parameters.Add("message_deny", messageDeny.ToApiString());
            if (photoNew != null)
                parameters.Add("photo_new", photoNew.ToApiString());
            if (audioNew != null)
                parameters.Add("audio_new", audioNew.ToApiString());
            if (videoNew != null)
                parameters.Add("video_new", videoNew.ToApiString());
            if (wallReplyNew != null)
                parameters.Add("wall_reply_new", wallReplyNew.ToApiString());
            if (wallReplyEdit != null)
                parameters.Add("wall_reply_edit", wallReplyEdit.ToApiString());
            if (wallPostNew != null)
                parameters.Add("wall_post_new", wallPostNew.ToApiString());
            if (boardPostNew != null)
                parameters.Add("board_post_new", boardPostNew.ToApiString());
            if (boardPostEdit != null)
                parameters.Add("board_post_edit", boardPostEdit.ToApiString());
            if (boardPostRestore != null)
                parameters.Add("board_post_restore", boardPostRestore.ToApiString());
            if (boardPostDelete != null)
                parameters.Add("board_post_delete", boardPostDelete.ToApiString());
            if (photoCommentNew != null)
                parameters.Add("photo_comment_new", photoCommentNew.ToApiString());
            if (videoCommentNew != null)
                parameters.Add("video_comment_new", videoCommentNew.ToApiString());
            if (marketCommentNew != null)
                parameters.Add("market_comment_new", marketCommentNew.ToApiString());
            if (groupJoin != null)
                parameters.Add("group_join", groupJoin.ToApiString());
            if (groupLeave != null)
                parameters.Add("group_leave", groupLeave.ToApiString());

            return await _vkontakte.GetAsync<int>("groups.setCallbackSettings", parameters);
        }
    }
}