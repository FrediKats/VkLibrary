using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Groups API section.
    /// </summary>
    public class Groups
    {
        private Vkontakte _vkontakte;

        internal Groups(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns information specifying whether a user is a member of a community.
        /// Docs: <see href="https://vk.com/dev/groups.isMember">groups.isMember</see>
        /// </summary>
        /// <param name="group_id">ID or screen name of the community.</param>
        /// <param name="user_id">User ID.</param>
        /// <param name="user_ids">User IDs.</param>
        /// <param name="extended">'1' — to return an extended response with additional fields.; By default: '0'.</param>
        public async Task<int> IsMember(string group_id = null, int? user_id = null, IEnumerable<int?> user_ids = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id);
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (user_ids != null)
                parameters.Add("user_ids", string.Join(",", user_ids));
            if (extended != null)
                parameters.Add("extended", extended.ToString());

            return await _vkontakte.GetAsync<int>("groups.isMember", parameters);
        }

        /// <summary>
        /// Returns information about communities by their IDs.
        /// Docs: <see href="https://vk.com/dev/groups.getById">groups.getById</see>
        /// </summary>
        /// <param name="group_ids">IDs or screen names of communities.</param>
        /// <param name="group_id">ID or screen name of the community.</param>
        /// <param name="fields">Group fields to return.;</param>
        public async Task<IEnumerable<VkLib.Types.Groups.GroupFull>> GetById(IEnumerable<string> group_ids = null, string group_id = null, IEnumerable<string> fields = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_ids != null)
                parameters.Add("group_ids", string.Join(",", group_ids));
            if (group_id != null)
                parameters.Add("group_id", group_id);
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Groups.GroupFull>>("groups.getById", parameters);
        }

        /// <summary>
        /// Returns a list of the communities to which a user belongs.; ;
        /// Docs: <see href="https://vk.com/dev/groups.get">groups.get</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="extended">'1' — to return complete information about a user's communities; '0' — to return a list of community IDs without any additional fields (default);</param>
        /// <param name="filter">Types of communities to return:; 'admin' — to return communities administered by the user ; 'editor' — to return communities where the user is an administrator or editor; 'moder' — to return communities where the user is an administrator, editor, or moderator; 'groups' — to return only groups; 'publics' — to return only public pages; 'events' — to return only events</param>
        /// <param name="fields">Profile fields to return.;</param>
        /// <param name="offset">Offset needed to return a specific subset of communities.</param>
        /// <param name="count">Number of communities to return.</param>
        public async Task<ApiItemsResponse<Types.Groups.GroupFull>> Get(int? user_id = null, bool? extended = true, IEnumerable<string> filter = null, IEnumerable<string> fields = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (extended != null)
                parameters.Add("extended", extended.ToString());
            if (filter != null)
                parameters.Add("filter", string.Join(",", filter));
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<ApiItemsResponse<Types.Groups.GroupFull>>("groups.get", parameters);
        }

        /// <summary>
        /// Returns a list of community members.
        /// Docs: <see href="https://vk.com/dev/groups.getMembers">groups.getMembers</see>
        /// </summary>
        /// <param name="group_id">ID or screen name of the community.</param>
        /// <param name="sort">Sort order. Available values: 'id_asc', 'id_desc', 'time_asc', 'time_desc'.; 'time_asc' and 'time_desc' are availavle only if the method is called by the group's 'moderator'.</param>
        /// <param name="offset">Offset needed to return a specific subset of community members.</param>
        /// <param name="count">Number of community members to return.</param>
        /// <param name="fields">List of additional fields to be returned. ; Available values: 'sex, bdate, city, country, photo_50, photo_100, photo_200_orig, photo_200, photo_400_orig, photo_max, photo_max_orig, online, online_mobile, lists, domain, has_mobile, contacts, connections, site, education, universities, schools, can_post, can_see_all_posts, can_see_audio, can_write_private_message, status, last_seen, common_count, relation, relatives, counters'.</param>
        /// <param name="filter">*'friends' – only friends in this community will be returned;; *'unsure' – only those who pressed 'I may attend' will be returned (if it's an event).</param>
        public async Task<ApiItemsResponse<int?>> GetMembers(string group_id = null, string sort = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string filter = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id);
            if (sort != null)
                parameters.Add("sort", sort);
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (filter != null)
                parameters.Add("filter", filter);

            return await _vkontakte.GetAsync<ApiItemsResponse<int?>>("groups.getMembers", parameters);
        }

        /// <summary>
        /// With this method you can join the group or public page, and also confirm your participation in an event.
        /// Docs: <see href="https://vk.com/dev/groups.join">groups.join</see>
        /// </summary>
        /// <param name="group_id">ID or screen name of the community.</param>
        /// <param name="not_sure">Optional parameter which is taken into account when 'gid' belongs to the event:; '1' — Perhaps I will attend; '0' — I will be there for sure (default); ;</param>
        public async Task<int> Join(int? group_id = null, string not_sure = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (not_sure != null)
                parameters.Add("not_sure", not_sure);

            return await _vkontakte.GetAsync<int>("groups.join", parameters);
        }

        /// <summary>
        /// With this method you can leave a group, public page, or event.; ;
        /// Docs: <see href="https://vk.com/dev/groups.leave">groups.leave</see>
        /// </summary>
        /// <param name="group_id">ID or screen name of the community.</param>
        public async Task<int> Leave(int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());

            return await _vkontakte.GetAsync<int>("groups.leave", parameters);
        }

        /// <summary>
        /// Returns a list of communities matching the search criteria.
        /// Docs: <see href="https://vk.com/dev/groups.search">groups.search</see>
        /// </summary>
        /// <param name="q">Search query string.</param>
        /// <param name="type">Community type. Possible values: 'group, page, event.'</param>
        /// <param name="country_id">Country ID.</param>
        /// <param name="city_id">City ID. If this parameter is transmitted, country_id is ignored.</param>
        /// <param name="future">'1' — to return only upcoming events. Works with the 'type' = 'event' only.</param>
        /// <param name="market">'1' — to return communities with enabled market only.</param>
        /// <param name="sort">Sort order. Possible values:; *'0' — default sorting (similar the full version of the site);; *'1' — by growth speed;; *'2'— by the "day attendance/members number" ratio;; *'3' — by the "Likes number/members number" ratio;; *'4' — by the "comments number/members number" ratio;; *'5' — by the "boards entries number/members number" ratio.; ;</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of communities to return.; "Note that you can not receive more than first thousand of results, regardless of 'count' and 'offset' values."</param>
        public async Task<ApiItemsResponse<VkLib.Types.Groups.Group>> Search(string q = null, string type = null, int? country_id = null, int? city_id = null, bool? future = null, bool? market = null, int? sort = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (type != null)
                parameters.Add("type", type);
            if (country_id != null)
                parameters.Add("country_id", country_id.ToString());
            if (city_id != null)
                parameters.Add("city_id", city_id.ToString());
            if (future != null)
                parameters.Add("future", future.ToString());
            if (market != null)
                parameters.Add("market", market.ToString());
            if (sort != null)
                parameters.Add("sort", sort.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Groups.Group>>("groups.search", parameters);
        }

        /// <summary>
        /// Returns communities list for a catalog category.
        /// Docs: <see href="https://vk.com/dev/groups.getCatalog">groups.getCatalog</see>
        /// </summary>
        /// <param name="category_id">Category id received from [vk.com/dev/groups.getCatalogInfo|groups.getCatalogInfo].</param>
        /// <param name="subcategory_id">Subcategory id received from [vk.com/dev/groups.getCatalogInfo|groups.getCatalogInfo].</param>
        public async Task<ApiItemsResponse<VkLib.Types.Groups.Group>> GetCatalog(int? category_id = null, int? subcategory_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (category_id != null)
                parameters.Add("category_id", category_id.ToString());
            if (subcategory_id != null)
                parameters.Add("subcategory_id", subcategory_id.ToString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Groups.Group>>("groups.getCatalog", parameters);
        }

        /// <summary>
        /// Returns categories list for communities catalog
        /// Docs: <see href="https://vk.com/dev/groups.getCatalogInfo">groups.getCatalogInfo</see>
        /// </summary>
        /// <param name="extended">1 – to return communities count and three communities for preview.; By default: 0.</param>
        /// <param name="subcategories">1 – to return subcategories info.; By default: 0.</param>
        public async Task<VkLib.Responses.Groups.GetCatalogInfoResponse> GetCatalogInfo(bool? extended = null, bool? subcategories = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (extended != null)
                parameters.Add("extended", extended.ToString());
            if (subcategories != null)
                parameters.Add("subcategories", subcategories.ToString());

            return await _vkontakte.GetAsync<VkLib.Responses.Groups.GetCatalogInfoResponse>("groups.getCatalogInfo", parameters);
        }

        /// <summary>
        /// Returns a list of invitations to join communities and events.; ;
        /// Docs: <see href="https://vk.com/dev/groups.getInvites">groups.getInvites</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of invitations.</param>
        /// <param name="count">Number of invitations to return.</param>
        /// <param name="extended">'1' — to return additional [vk.com/dev/fields_groups|fields] for communities..</param>
        public async Task<ApiItemsResponse<VkLib.Types.Groups.GroupXtrInvitedBy>> GetInvites(int? offset = null, int? count = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (extended != null)
                parameters.Add("extended", extended.ToString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Groups.GroupXtrInvitedBy>>("groups.getInvites", parameters);
        }

        /// <summary>
        /// Returns invited users list of a community
        /// Docs: <see href="https://vk.com/dev/groups.getInvitedUsers">groups.getInvitedUsers</see>
        /// </summary>
        /// <param name="group_id">Group ID to return invited users for.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of results to return.</param>
        /// <param name="fields">List of additional fields to be returned. ; Available values: 'sex, bdate, city, country, photo_50, photo_100, photo_200_orig, photo_200, photo_400_orig, photo_max, photo_max_orig, online, online_mobile, lists, domain, has_mobile, contacts, connections, site, education, universities, schools, can_post, can_see_all_posts, can_see_audio, can_write_private_message, status, last_seen, common_count, relation, relatives, counters'.</param>
        /// <param name="name_case">Case for declension of user name and surname. Possible values:; *'nom' — nominative (default);; *'gen' — genitive;; *'dat' — dative;; *'acc' — accusative; ; *'ins' — instrumental;; *'abl' — prepositional.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Users.UserFull>> GetInvitedUsers(int? group_id = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, string name_case = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (name_case != null)
                parameters.Add("name_case", name_case);

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Users.UserFull>>("groups.getInvitedUsers", parameters);
        }

        /// <summary>
        /// Adds a user to a community blacklist.
        /// Docs: <see href="https://vk.com/dev/groups.banUser">groups.banUser</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="user_id">User ID.</param>
        /// <param name="end_date">Date (in Unix time) when the user will be removed from the blacklist.</param>
        /// <param name="reason">Reason for ban:; '1' — spam; '2' — verbal abuse; '3' — strong language; '4' — irrelevant messages; '0' — other (default)</param>
        /// <param name="comment">Text of comment to ban.</param>
        /// <param name="comment_visible">'1' — text of comment will be visible to the user;; '0' — text of comment will be invisible to the user. ; By default: '0'.</param>
        public async Task<int> BanUser(int? group_id = null, int? user_id = null, int? end_date = null, int? reason = null, string comment = null, bool? comment_visible = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (end_date != null)
                parameters.Add("end_date", end_date.ToString());
            if (reason != null)
                parameters.Add("reason", reason.ToString());
            if (comment != null)
                parameters.Add("comment", comment);
            if (comment_visible != null)
                parameters.Add("comment_visible", comment_visible.ToString());

            return await _vkontakte.GetAsync<int>("groups.banUser", parameters);
        }

        /// <summary>
        /// Removes a user from a community blacklist.
        /// Docs: <see href="https://vk.com/dev/groups.unbanUser">groups.unbanUser</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="user_id">User ID.</param>
        public async Task<int> UnbanUser(int? group_id = null, int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());

            return await _vkontakte.GetAsync<int>("groups.unbanUser", parameters);
        }

        /// <summary>
        /// Returns a list of users on a community blacklist.
        /// Docs: <see href="https://vk.com/dev/groups.getBanned">groups.getBanned</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of users.</param>
        /// <param name="count">Number of users to return.</param>
        /// <param name="fields"></param>
        /// <param name="user_id"></param>
        public async Task<ApiItemsResponse<VkLib.Types.Groups.UserXtrBanInfo>> GetBanned(int? group_id = null, int? offset = null, int? count = null, IEnumerable<string> fields = null, int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Groups.UserXtrBanInfo>>("groups.getBanned", parameters);
        }

        /// <summary>
        /// Creates a new community.
        /// Docs: <see href="https://vk.com/dev/groups.create">groups.create</see>
        /// </summary>
        /// <param name="title">Community title.</param>
        /// <param name="description">Community description (ignored for 'type' = 'public').</param>
        /// <param name="type">Community type. Possible values:; *'group' – group;; *'event' – event;; *'public' – public page</param>
        /// <param name="public_category">Category ID (for 'type' = 'public' only).</param>
        /// <param name="subtype">Public page subtype. Possible values:; *'1' – place or small business;; *'2' – company, organization or website;; *'3' – famous person or group of people;; *'4' – product or work of art.</param>
        public async Task<VkLib.Types.Groups.Group> Create(string title = null, string description = null, string type = null, int? public_category = null, int? subtype = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (title != null)
                parameters.Add("title", title);
            if (description != null)
                parameters.Add("description", description);
            if (type != null)
                parameters.Add("type", type);
            if (public_category != null)
                parameters.Add("public_category", public_category.ToString());
            if (subtype != null)
                parameters.Add("subtype", subtype.ToString());

            return await _vkontakte.GetAsync<VkLib.Types.Groups.Group>("groups.create", parameters);
        }

        /// <summary>
        /// Edits a community.
        /// Docs: <see href="https://vk.com/dev/groups.edit">groups.edit</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="title">Community title.</param>
        /// <param name="description">Community description.</param>
        /// <param name="screen_name">Community screen name.</param>
        /// <param name="access">Community type. Possible values:; *'0' – open;; *'1' – closed;; *'2' – private.</param>
        /// <param name="website">Website that will be displayed in the community information field.</param>
        /// <param name="subject">Community subject. Possible values: ; *'1' – auto/moto;; *'2' – activity holidays;; *'3' – business;; *'4' – pets;; *'5' – health;; *'6' – dating and communication; ; *'7' – games;; *'8' – IT (computers and software);; *'9' – cinema;; *'10' – beauty and fashion;; *'11' – cooking;; *'12' – art and culture;; *'13' – literature;; *'14' – mobile services and internet;; *'15' – music;; *'16' – science and technology;; *'17' – real estate;; *'18' – news and media;; *'19' – security;; *'20' – education;; *'21' – home and renovations;; *'22' – politics;; *'23' – food;; *'24' – industry;; *'25' – travel;; *'26' – work;; *'27' – entertainment;; *'28' – religion;; *'29' – family;; *'30' – sports;; *'31' – insurance;; *'32' – television;; *'33' – goods and services;; *'34' – hobbies;; *'35' – finance;; *'36' – photo;; *'37' – esoterics;; *'38' – electronics and appliances;; *'39' – erotic;; *'40' – humor;; *'41' – society, humanities;; *'42' – design and graphics.</param>
        /// <param name="email">Organizer email (for events).</param>
        /// <param name="phone">Organizer phone number (for events).</param>
        /// <param name="rss">RSS feed address for import (available only to communities with special permission. Contact vk.com/support to get it.</param>
        /// <param name="event_start_date">Event start date in Unixtime format.</param>
        /// <param name="event_finish_date">Event finish date in Unixtime format.</param>
        /// <param name="event_group_id">Organizer community ID (for events only).</param>
        /// <param name="public_category">Public page category ID.</param>
        /// <param name="public_subcategory">Public page subcategory ID.</param>
        /// <param name="public_date">Founding date of a company or organization owning the community in "dd.mm.YYYY" format.</param>
        /// <param name="wall">Wall settings. Possible values:; *'0' – disabled;; *'1' – open;; *'2' – limited (groups and events only);; *'3' – closed (groups and events only).;</param>
        /// <param name="topics">Board topics settings. Possbile values: ; *'0' – disabled;; *'1' – open;; *'2' – limited (for groups and events only).;</param>
        /// <param name="photos">Photos settings. Possible values:; *'0' – disabled;; *'1' – open;; *'2' – limited (for groups and events only).;</param>
        /// <param name="video">Video settings. Possible values:; *'0' – disabled;; *'1' – open;; *'2' – limited (for groups and events only).</param>
        /// <param name="audio">Audio settings. Possible values:; *'0' – disabled;; *'1' – open;; *'2' – limited (for groups and events only).</param>
        /// <param name="links">Links settings (for public pages only). Possible values:; *'0' – disabled;; *'1' – enabled.;</param>
        /// <param name="events">Events settings (for public pages only). Possible values:; *'0' – disabled;; *'1' – enabled.;</param>
        /// <param name="places">Places settings (for public pages only). Possible values:; *'0' – disabled;; *'1' – enabled.;</param>
        /// <param name="contacts">Contacts settings (for public pages only). Possible values:; *'0' – disabled;; *'1' – enabled.;</param>
        /// <param name="docs">Documents settings. Possible values:; *'0' – disabled;; *'1' – open;; *'2' – limited (for groups and events only).</param>
        /// <param name="wiki">Wiki pages settings. Possible values:; *'0' – disabled;; *'1' – open;; *'2' – limited (for groups and events only).</param>
        /// <param name="messages">Community messages. Possible values:; *'0' — disabled;; *'1' — enabled.</param>
        /// <param name="age_limits">Community age limits. Possible values:; *'1' — no limits;; *'2' — 16+;; *'3' — 18+.</param>
        /// <param name="market">Market settings. Possible values:; *'0' – disabled;; *'1' – enabled.</param>
        /// <param name="market_comments">market comments settings. Possible values:; *'0' – disabled;; *'1' – enabled.</param>
        /// <param name="market_country">Market delivery countries.</param>
        /// <param name="market_city">Market delivery cities (if only one country is specified).</param>
        /// <param name="market_currency">Market currency settings. Possbile values: ; *'643' – Russian rubles;; *'980' – Ukrainian hryvnia;; *'398' – Kazakh tenge;; *'978' – Euro;; *'840' – US dollars</param>
        /// <param name="market_contact">Seller contact for market.; Set '0' for community messages.</param>
        /// <param name="market_wiki">ID of a wiki page with market description.</param>
        /// <param name="obscene_filter">Obscene expressions filter in comments. Possible values: ; *'0' – disabled;; *'1' – enabled.</param>
        /// <param name="obscene_stopwords">Stopwords filter in comments. Possible values: ; *'0' – disabled;; *'1' – enabled.</param>
        /// <param name="obscene_words">Keywords for stopwords filter.</param>
        public async Task<int> Edit(int? group_id = null, string title = null, string description = null, string screen_name = null, int? access = null, string website = null, string subject = null, string email = null, string phone = null, string rss = null, int? event_start_date = null, int? event_finish_date = null, int? event_group_id = null, int? public_category = null, int? public_subcategory = null, string public_date = null, int? wall = null, int? topics = null, int? photos = null, int? video = null, int? audio = null, bool? links = null, bool? events = null, bool? places = null, bool? contacts = null, int? docs = null, int? wiki = null, bool? messages = null, int? age_limits = null, bool? market = null, bool? market_comments = null, IEnumerable<int?> market_country = null, IEnumerable<int?> market_city = null, int? market_currency = null, int? market_contact = null, int? market_wiki = null, bool? obscene_filter = null, bool? obscene_stopwords = null, IEnumerable<string> obscene_words = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (title != null)
                parameters.Add("title", title);
            if (description != null)
                parameters.Add("description", description);
            if (screen_name != null)
                parameters.Add("screen_name", screen_name);
            if (access != null)
                parameters.Add("access", access.ToString());
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
            if (event_start_date != null)
                parameters.Add("event_start_date", event_start_date.ToString());
            if (event_finish_date != null)
                parameters.Add("event_finish_date", event_finish_date.ToString());
            if (event_group_id != null)
                parameters.Add("event_group_id", event_group_id.ToString());
            if (public_category != null)
                parameters.Add("public_category", public_category.ToString());
            if (public_subcategory != null)
                parameters.Add("public_subcategory", public_subcategory.ToString());
            if (public_date != null)
                parameters.Add("public_date", public_date);
            if (wall != null)
                parameters.Add("wall", wall.ToString());
            if (topics != null)
                parameters.Add("topics", topics.ToString());
            if (photos != null)
                parameters.Add("photos", photos.ToString());
            if (video != null)
                parameters.Add("video", video.ToString());
            if (audio != null)
                parameters.Add("audio", audio.ToString());
            if (links != null)
                parameters.Add("links", links.ToString());
            if (events != null)
                parameters.Add("events", events.ToString());
            if (places != null)
                parameters.Add("places", places.ToString());
            if (contacts != null)
                parameters.Add("contacts", contacts.ToString());
            if (docs != null)
                parameters.Add("docs", docs.ToString());
            if (wiki != null)
                parameters.Add("wiki", wiki.ToString());
            if (messages != null)
                parameters.Add("messages", messages.ToString());
            if (age_limits != null)
                parameters.Add("age_limits", age_limits.ToString());
            if (market != null)
                parameters.Add("market", market.ToString());
            if (market_comments != null)
                parameters.Add("market_comments", market_comments.ToString());
            if (market_country != null)
                parameters.Add("market_country", string.Join(",", market_country));
            if (market_city != null)
                parameters.Add("market_city", string.Join(",", market_city));
            if (market_currency != null)
                parameters.Add("market_currency", market_currency.ToString());
            if (market_contact != null)
                parameters.Add("market_contact", market_contact.ToString());
            if (market_wiki != null)
                parameters.Add("market_wiki", market_wiki.ToString());
            if (obscene_filter != null)
                parameters.Add("obscene_filter", obscene_filter.ToString());
            if (obscene_stopwords != null)
                parameters.Add("obscene_stopwords", obscene_stopwords.ToString());
            if (obscene_words != null)
                parameters.Add("obscene_words", string.Join(",", obscene_words));

            return await _vkontakte.GetAsync<int>("groups.edit", parameters);
        }

        /// <summary>
        /// Edits the place in community.
        /// Docs: <see href="https://vk.com/dev/groups.editPlace">groups.editPlace</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="title">Place title.</param>
        /// <param name="address">Place address.</param>
        /// <param name="country_id">Country ID.</param>
        /// <param name="city_id">City ID.</param>
        /// <param name="latitude">Geographical latitude.</param>
        /// <param name="longitude">Geographical longitude.</param>
        public async Task<VkLib.Responses.Groups.EditPlaceResponse> EditPlace(int? group_id = null, string title = null, string address = null, int? country_id = null, int? city_id = null, uint? latitude = null, uint? longitude = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (title != null)
                parameters.Add("title", title);
            if (address != null)
                parameters.Add("address", address);
            if (country_id != null)
                parameters.Add("country_id", country_id.ToString());
            if (city_id != null)
                parameters.Add("city_id", city_id.ToString());
            if (latitude != null)
                parameters.Add("latitude", latitude.ToString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToString());

            return await _vkontakte.GetAsync<VkLib.Responses.Groups.EditPlaceResponse>("groups.editPlace", parameters);
        }

        /// <summary>
        /// Returns community settings.
        /// Docs: <see href="https://vk.com/dev/groups.getSettings">groups.getSettings</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        public async Task<VkLib.Types.Groups.GroupSettings> GetSettings(int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());

            return await _vkontakte.GetAsync<VkLib.Types.Groups.GroupSettings>("groups.getSettings", parameters);
        }

        /// <summary>
        /// Returns a list of requests to the community.
        /// Docs: <see href="https://vk.com/dev/groups.getRequests">groups.getRequests</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of results to return.</param>
        /// <param name="fields">Profile fields to return.;</param>
        public async Task<ApiItemsResponse<int?>> GetRequests(int? group_id = null, int? offset = null, int? count = null, IEnumerable<string> fields = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));

            return await _vkontakte.GetAsync<ApiItemsResponse<int?>>("groups.getRequests", parameters);
        }

        /// <summary>
        /// Allows to add, remove or edit the community manager.
        /// Docs: <see href="https://vk.com/dev/groups.editManager">groups.editManager</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="user_id">User ID.</param>
        /// <param name="role">Manager role. Possible values:; *'moderator';; *'editor';; *'administrator'.</param>
        /// <param name="is_contact">'1' — to show the manager in Contacts block of the community.</param>
        /// <param name="contact_position">Position to show in Contacts block.</param>
        /// <param name="contact_phone">Contact phone.</param>
        /// <param name="contact_email">Contact e-mail.</param>
        public async Task<int> EditManager(int? group_id = null, int? user_id = null, string role = null, bool? is_contact = null, string contact_position = null, string contact_phone = null, string contact_email = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (role != null)
                parameters.Add("role", role);
            if (is_contact != null)
                parameters.Add("is_contact", is_contact.ToString());
            if (contact_position != null)
                parameters.Add("contact_position", contact_position);
            if (contact_phone != null)
                parameters.Add("contact_phone", contact_phone);
            if (contact_email != null)
                parameters.Add("contact_email", contact_email);

            return await _vkontakte.GetAsync<int>("groups.editManager", parameters);
        }

        /// <summary>
        /// Allows to invite friends to the community.
        /// Docs: <see href="https://vk.com/dev/groups.invite">groups.invite</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="user_id">User ID.</param>
        public async Task<int> Invite(int? group_id = null, int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());

            return await _vkontakte.GetAsync<int>("groups.invite", parameters);
        }

        /// <summary>
        /// Allows to add a link to the community.
        /// Docs: <see href="https://vk.com/dev/groups.addLink">groups.addLink</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="link">Link URL.</param>
        /// <param name="text">Description text for the link.</param>
        public async Task<VkLib.Types.Groups.GroupLink> AddLink(int? group_id = null, string link = null, string text = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (link != null)
                parameters.Add("link", link);
            if (text != null)
                parameters.Add("text", text);

            return await _vkontakte.GetAsync<VkLib.Types.Groups.GroupLink>("groups.addLink", parameters);
        }

        /// <summary>
        /// Allows to delete a link from the community.
        /// Docs: <see href="https://vk.com/dev/groups.deleteLink">groups.deleteLink</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="link_id">Link ID.</param>
        public async Task<int> DeleteLink(int? group_id = null, int? link_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (link_id != null)
                parameters.Add("link_id", link_id.ToString());

            return await _vkontakte.GetAsync<int>("groups.deleteLink", parameters);
        }

        /// <summary>
        /// Allows to edit a link in the community.
        /// Docs: <see href="https://vk.com/dev/groups.editLink">groups.editLink</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="link_id">Link ID.</param>
        /// <param name="text">New description text for the link.</param>
        public async Task<int> EditLink(int? group_id = null, int? link_id = null, string text = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (link_id != null)
                parameters.Add("link_id", link_id.ToString());
            if (text != null)
                parameters.Add("text", text);

            return await _vkontakte.GetAsync<int>("groups.editLink", parameters);
        }

        /// <summary>
        /// Allows to reorder links in the community.
        /// Docs: <see href="https://vk.com/dev/groups.reorderLink">groups.reorderLink</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="link_id">Link ID.</param>
        /// <param name="after">ID of the link after which to place the link with 'link_id'.</param>
        public async Task<int> ReorderLink(int? group_id = null, int? link_id = null, int? after = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (link_id != null)
                parameters.Add("link_id", link_id.ToString());
            if (after != null)
                parameters.Add("after", after.ToString());

            return await _vkontakte.GetAsync<int>("groups.reorderLink", parameters);
        }

        /// <summary>
        /// Removes a user from the community.
        /// Docs: <see href="https://vk.com/dev/groups.removeUser">groups.removeUser</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="user_id">User ID.</param>
        public async Task<int> RemoveUser(int? group_id = null, int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());

            return await _vkontakte.GetAsync<int>("groups.removeUser", parameters);
        }

        /// <summary>
        /// Allows to approve join request to the community.
        /// Docs: <see href="https://vk.com/dev/groups.approveRequest">groups.approveRequest</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="user_id">User ID.</param>
        public async Task<int> ApproveRequest(int? group_id = null, int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());

            return await _vkontakte.GetAsync<int>("groups.approveRequest", parameters);
        }

        /// <summary>
        /// Returns Callback API confirmation code for the community.
        /// Docs: <see href="https://vk.com/dev/groups.getCallbackConfirmationCode">groups.getCallbackConfirmationCode</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        public async Task<VkLib.Responses.Groups.GetCallbackConfirmationCodeResponse> GetCallbackConfirmationCode(int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());

            return await _vkontakte.GetAsync<VkLib.Responses.Groups.GetCallbackConfirmationCodeResponse>("groups.getCallbackConfirmationCode", parameters);
        }

        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] server settings for the community.
        /// Docs: <see href="https://vk.com/dev/groups.getCallbackServerSettings">groups.getCallbackServerSettings</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        public async Task<VkLib.Responses.Groups.GetCallbackServerSettingsResponse> GetCallbackServerSettings(int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());

            return await _vkontakte.GetAsync<VkLib.Responses.Groups.GetCallbackServerSettingsResponse>("groups.getCallbackServerSettings", parameters);
        }

        /// <summary>
        /// Returns [vk.com/dev/callback_api|Callback API] notifications settings.
        /// Docs: <see href="https://vk.com/dev/groups.getCallbackSettings">groups.getCallbackSettings</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        public async Task<VkLib.Responses.Groups.GetCallbackSettingsResponse> GetCallbackSettings(int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());

            return await _vkontakte.GetAsync<VkLib.Responses.Groups.GetCallbackSettingsResponse>("groups.getCallbackSettings", parameters);
        }

        /// <summary>
        /// Allow to set [vk.com/dev/callback_api|Callback API] server URL for the community. ; ;
        /// Docs: <see href="https://vk.com/dev/groups.setCallbackServer">groups.setCallbackServer</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="server_url">Server URL.</param>
        public async Task<VkLib.Responses.Groups.SetCallbackServerResponse> SetCallbackServer(int? group_id = null, string server_url = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (server_url != null)
                parameters.Add("server_url", server_url);

            return await _vkontakte.GetAsync<VkLib.Responses.Groups.SetCallbackServerResponse>("groups.setCallbackServer", parameters);
        }

        /// <summary>
        /// Allow to set [vk.com/dev/callback_api|Callback API] server settings.
        /// Docs: <see href="https://vk.com/dev/groups.setCallbackServerSettings">groups.setCallbackServerSettings</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="secret_key">Callback API secret key.</param>
        public async Task<int> SetCallbackServerSettings(int? group_id = null, string secret_key = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (secret_key != null)
                parameters.Add("secret_key", secret_key);

            return await _vkontakte.GetAsync<int>("groups.setCallbackServerSettings", parameters);
        }

        /// <summary>
        /// Allow to set notifications settings for group.
        /// Docs: <see href="https://vk.com/dev/groups.setCallbackSettings">groups.setCallbackSettings</see>
        /// </summary>
        /// <param name="group_id">Community ID.</param>
        /// <param name="message_new">New messages notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="message_allow">Allowed messages notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="message_deny">Denied messages notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="photo_new">New photos notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="audio_new">New audios notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="video_new">New videos notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="wall_reply_new">New wall replies notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="wall_reply_edit">Wall replies edited notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="wall_post_new">New wall posts notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="board_post_new">New board posts notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="board_post_edit">Board posts edited notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="board_post_restore">Board posts restored notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="board_post_delete">Board posts deleted notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="photo_comment_new">New comment to photo notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="video_comment_new">New comment to video notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="market_comment_new">New comment to market item notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="group_join">Joined community notifications ('0' — disabled, '1' — enabled).</param>
        /// <param name="group_leave">Left community notifications ('0' — disabled, '1' — enabled).</param>
        public async Task<int> SetCallbackSettings(int? group_id = null, bool? message_new = null, bool? message_allow = null, bool? message_deny = null, bool? photo_new = null, bool? audio_new = null, bool? video_new = null, bool? wall_reply_new = null, bool? wall_reply_edit = null, bool? wall_post_new = null, bool? board_post_new = null, bool? board_post_edit = null, bool? board_post_restore = null, bool? board_post_delete = null, bool? photo_comment_new = null, bool? video_comment_new = null, bool? market_comment_new = null, bool? group_join = null, bool? group_leave = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (message_new != null)
                parameters.Add("message_new", message_new.ToString());
            if (message_allow != null)
                parameters.Add("message_allow", message_allow.ToString());
            if (message_deny != null)
                parameters.Add("message_deny", message_deny.ToString());
            if (photo_new != null)
                parameters.Add("photo_new", photo_new.ToString());
            if (audio_new != null)
                parameters.Add("audio_new", audio_new.ToString());
            if (video_new != null)
                parameters.Add("video_new", video_new.ToString());
            if (wall_reply_new != null)
                parameters.Add("wall_reply_new", wall_reply_new.ToString());
            if (wall_reply_edit != null)
                parameters.Add("wall_reply_edit", wall_reply_edit.ToString());
            if (wall_post_new != null)
                parameters.Add("wall_post_new", wall_post_new.ToString());
            if (board_post_new != null)
                parameters.Add("board_post_new", board_post_new.ToString());
            if (board_post_edit != null)
                parameters.Add("board_post_edit", board_post_edit.ToString());
            if (board_post_restore != null)
                parameters.Add("board_post_restore", board_post_restore.ToString());
            if (board_post_delete != null)
                parameters.Add("board_post_delete", board_post_delete.ToString());
            if (photo_comment_new != null)
                parameters.Add("photo_comment_new", photo_comment_new.ToString());
            if (video_comment_new != null)
                parameters.Add("video_comment_new", video_comment_new.ToString());
            if (market_comment_new != null)
                parameters.Add("market_comment_new", market_comment_new.ToString());
            if (group_join != null)
                parameters.Add("group_join", group_join.ToString());
            if (group_leave != null)
                parameters.Add("group_leave", group_leave.ToString());

            return await _vkontakte.GetAsync<int>("groups.setCallbackSettings", parameters);
        }

    }
}
