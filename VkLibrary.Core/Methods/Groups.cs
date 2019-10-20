using VkLibrary.Core.Objects;
using VkLibrary.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Methods
{
    public class Groups
    {
        private readonly Vkontakte _vkontakte;

        internal Groups(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Allows to add a link to the community.
        ///</summary>
        public Task<GroupsGroupLink> AddLink(int? groupId = null, String link = null, String text = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (link != null)
                parameters.Add("link", link.ToApiString());
            if (text != null)
                parameters.Add("text", text.ToApiString());
            return _vkontakte.RequestAsync<GroupsGroupLink>("groups.addLink", parameters);
        }

        ///<summary>
        /// Allows to approve join request to the community.
        ///</summary>
        public Task<BaseOkResponse> ApproveRequest(int? groupId = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("groups.approveRequest", parameters);
        }

        ///<summary>
        /// Creates a new community.
        ///</summary>
        public Task<GroupsGroup> Create(String title = null, String description = null, String type = null, int? publicCategory = null, int? subtype = null)
        {
            var parameters = new Dictionary<string, string>();
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (description != null)
                parameters.Add("description", description.ToApiString());
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (publicCategory != null)
                parameters.Add("public_category", publicCategory.ToApiString());
            if (subtype != null)
                parameters.Add("subtype", subtype.ToApiString());
            return _vkontakte.RequestAsync<GroupsGroup>("groups.create", parameters);
        }

        ///<summary>
        /// Allows to delete a link from the community.
        ///</summary>
        public Task<BaseOkResponse> DeleteLink(int? groupId = null, int? linkId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (linkId != null)
                parameters.Add("link_id", linkId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("groups.deleteLink", parameters);
        }

        ///<summary>
        /// Edits a community.
        ///</summary>
        public Task<BaseOkResponse> Edit(int? groupId = null, String title = null, String description = null, String screenName = null, int? access = null, String website = null, String subject = null, String email = null, String phone = null, String rss = null, int? eventStartDate = null, int? eventFinishDate = null, int? eventGroupId = null, int? publicCategory = null, int? publicSubcategory = null, String publicDate = null, int? wall = null, int? topics = null, int? photos = null, int? video = null, int? audio = null, Boolean? links = null, Boolean? events = null, Boolean? places = null, Boolean? contacts = null, int? docs = null, int? wiki = null, Boolean? messages = null, Boolean? articles = null, Boolean? addresses = null, int? ageLimits = null, Boolean? market = null, Boolean? marketComments = null, int[] marketCountry = null, int[] marketCity = null, int? marketCurrency = null, int? marketContact = null, int? marketWiki = null, Boolean? obsceneFilter = null, Boolean? obsceneStopwords = null, String[] obsceneWords = null, int? mainSection = null, int? secondarySection = null, int? country = null, int? city = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (description != null)
                parameters.Add("description", description.ToApiString());
            if (screenName != null)
                parameters.Add("screen_name", screenName.ToApiString());
            if (access != null)
                parameters.Add("access", access.ToApiString());
            if (website != null)
                parameters.Add("website", website.ToApiString());
            if (subject != null)
                parameters.Add("subject", subject.ToApiString());
            if (email != null)
                parameters.Add("email", email.ToApiString());
            if (phone != null)
                parameters.Add("phone", phone.ToApiString());
            if (rss != null)
                parameters.Add("rss", rss.ToApiString());
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
                parameters.Add("public_date", publicDate.ToApiString());
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
            if (articles != null)
                parameters.Add("articles", articles.ToApiString());
            if (addresses != null)
                parameters.Add("addresses", addresses.ToApiString());
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
            if (mainSection != null)
                parameters.Add("main_section", mainSection.ToApiString());
            if (secondarySection != null)
                parameters.Add("secondary_section", secondarySection.ToApiString());
            if (country != null)
                parameters.Add("country", country.ToApiString());
            if (city != null)
                parameters.Add("city", city.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("groups.edit", parameters);
        }

        ///<summary>
        /// Allows to edit a link in the community.
        ///</summary>
        public Task<BaseOkResponse> EditLink(int? groupId = null, int? linkId = null, String text = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (linkId != null)
                parameters.Add("link_id", linkId.ToApiString());
            if (text != null)
                parameters.Add("text", text.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("groups.editLink", parameters);
        }

        ///<summary>
        /// Allows to add, remove or edit the community manager.
        ///</summary>
        public Task<BaseOkResponse> EditManager(int? groupId = null, int? userId = null, String role = null, Boolean? isContact = null, String contactPosition = null, String contactPhone = null, String contactEmail = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (role != null)
                parameters.Add("role", role.ToApiString());
            if (isContact != null)
                parameters.Add("is_contact", isContact.ToApiString());
            if (contactPosition != null)
                parameters.Add("contact_position", contactPosition.ToApiString());
            if (contactPhone != null)
                parameters.Add("contact_phone", contactPhone.ToApiString());
            if (contactEmail != null)
                parameters.Add("contact_email", contactEmail.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("groups.editManager", parameters);
        }

        ///<summary>
        /// Returns a list of the communities to which a user belongs.
        ///</summary>
        public Task<GroupsGetResponse> Get(int? userId = null, Boolean? extended = null, GroupsFilter[] filter = null, GroupsFields[] fields = null, int? offset = null, int? count = null)
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
            return _vkontakte.RequestAsync<GroupsGetResponse>("groups.get", parameters);
        }

        ///<summary>
        /// Returns a list of community addresses.
        ///</summary>
        public Task<GroupsGetAddressesResponse> GetAddresses(int? groupId = null, int[] addressIds = null, double? latitude = null, double? longitude = null, int? offset = null, int? count = null, AddressesFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (addressIds != null)
                parameters.Add("address_ids", addressIds.ToApiString());
            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<GroupsGetAddressesResponse>("groups.getAddresses", parameters);
        }

        ///<summary>
        /// Returns a list of users on a community blacklist.
        ///</summary>
        public Task<GroupsGetBannedResponse> GetBanned(int? groupId = null, int? offset = null, int? count = null, BaseUserGroupFields[] fields = null, int? ownerId = null)
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
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            return _vkontakte.RequestAsync<GroupsGetBannedResponse>("groups.getBanned", parameters);
        }

        ///<summary>
        /// Returns information about communities by their IDs.
        ///</summary>
        public Task<GroupsGroupFull[]> GetById(String[] groupIds = null, String groupId = null, GroupsFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupIds != null)
                parameters.Add("group_ids", groupIds.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<GroupsGroupFull[]>("groups.getById", parameters);
        }

        ///<summary>
        /// Returns Callback API confirmation code for the community.
        ///</summary>
        public Task<GroupsGetCallbackConfirmationCodeResponse> GetCallbackConfirmationCode(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<GroupsGetCallbackConfirmationCodeResponse>("groups.getCallbackConfirmationCode", parameters);
        }

        ///<summary>
        /// Returns [vk.com/dev/callback_api|Callback API] notifications settings.
        ///</summary>
        public Task<GroupsCallbackSettings> GetCallbackSettings(int? groupId = null, int? serverId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (serverId != null)
                parameters.Add("server_id", serverId.ToApiString());
            return _vkontakte.RequestAsync<GroupsCallbackSettings>("groups.getCallbackSettings", parameters);
        }

        ///<summary>
        /// Returns communities list for a catalog category.
        ///</summary>
        public Task<GroupsGetCatalogResponse> GetCatalog(int? categoryId = null, int? subcategoryId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (categoryId != null)
                parameters.Add("category_id", categoryId.ToApiString());
            if (subcategoryId != null)
                parameters.Add("subcategory_id", subcategoryId.ToApiString());
            return _vkontakte.RequestAsync<GroupsGetCatalogResponse>("groups.getCatalog", parameters);
        }

        ///<summary>
        /// Returns categories list for communities catalog
        ///</summary>
        public Task<GroupsGetCatalogInfoResponse> GetCatalogInfo(Boolean? extended = null, Boolean? subcategories = null)
        {
            var parameters = new Dictionary<string, string>();
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (subcategories != null)
                parameters.Add("subcategories", subcategories.ToApiString());
            return _vkontakte.RequestAsync<GroupsGetCatalogInfoResponse>("groups.getCatalogInfo", parameters);
        }

        ///<summary>
        /// Returns invited users list of a community
        ///</summary>
        public Task<GroupsGetInvitedUsersResponse> GetInvitedUsers(int? groupId = null, int? offset = null, int? count = null, UsersFields[] fields = null, String nameCase = null)
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
                parameters.Add("name_case", nameCase.ToApiString());
            return _vkontakte.RequestAsync<GroupsGetInvitedUsersResponse>("groups.getInvitedUsers", parameters);
        }

        ///<summary>
        /// Returns a list of invitations to join communities and events.
        ///</summary>
        public Task<GroupsGetInvitesResponse> GetInvites(int? offset = null, int? count = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<GroupsGetInvitesResponse>("groups.getInvites", parameters);
        }

        ///<summary>
        /// Returns the data needed to query a Long Poll server for events
        ///</summary>
        public Task<GroupsLongPollServer> GetLongPollServer(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<GroupsLongPollServer>("groups.getLongPollServer", parameters);
        }

        ///<summary>
        /// Returns Long Poll notification settings
        ///</summary>
        public Task<GroupsLongPollSettings> GetLongPollSettings(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<GroupsLongPollSettings>("groups.getLongPollSettings", parameters);
        }

        ///<summary>
        /// Returns a list of community members.
        ///</summary>
        public Task<GroupsGetMembersResponse> GetMembers(String groupId = null, String sort = null, int? offset = null, int? count = null, UsersFields[] fields = null, String filter = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (filter != null)
                parameters.Add("filter", filter.ToApiString());
            return _vkontakte.RequestAsync<GroupsGetMembersResponse>("groups.getMembers", parameters);
        }

        ///<summary>
        /// Returns a list of requests to the community.
        ///</summary>
        public Task<GroupsGetRequestsResponse> GetRequests(int? groupId = null, int? offset = null, int? count = null, UsersFields[] fields = null)
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
            return _vkontakte.RequestAsync<GroupsGetRequestsResponse>("groups.getRequests", parameters);
        }

        ///<summary>
        /// Returns community settings.
        ///</summary>
        public Task<GroupsGroupSettings> GetSettings(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<GroupsGroupSettings>("groups.getSettings", parameters);
        }

        ///<summary>
        /// Allows to invite friends to the community.
        ///</summary>
        public Task<BaseOkResponse> Invite(int? groupId = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("groups.invite", parameters);
        }

        ///<summary>
        /// Returns information specifying whether a user is a member of a community.
        ///</summary>
        public Task<int> IsMember(String groupId = null, int? userId = null, int[] userIds = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<int>("groups.isMember", parameters);
        }

        ///<summary>
        /// With this method you can join the group or public page, and also confirm your participation in an event.
        ///</summary>
        public Task<BaseOkResponse> Join(int? groupId = null, String notSure = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (notSure != null)
                parameters.Add("not_sure", notSure.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("groups.join", parameters);
        }

        ///<summary>
        /// With this method you can leave a group, public page, or event.
        ///</summary>
        public Task<BaseOkResponse> Leave(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("groups.leave", parameters);
        }

        ///<summary>
        /// Removes a user from the community.
        ///</summary>
        public Task<BaseOkResponse> RemoveUser(int? groupId = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("groups.removeUser", parameters);
        }

        ///<summary>
        /// Allows to reorder links in the community.
        ///</summary>
        public Task<BaseOkResponse> ReorderLink(int? groupId = null, int? linkId = null, int? after = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (linkId != null)
                parameters.Add("link_id", linkId.ToApiString());
            if (after != null)
                parameters.Add("after", after.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("groups.reorderLink", parameters);
        }

        ///<summary>
        /// Returns a list of communities matching the search criteria.
        ///</summary>
        public Task<GroupsSearchResponse> Search(String q = null, String type = null, int? countryId = null, int? cityId = null, Boolean? future = null, Boolean? market = null, int? sort = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (type != null)
                parameters.Add("type", type.ToApiString());
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
            return _vkontakte.RequestAsync<GroupsSearchResponse>("groups.search", parameters);
        }

        ///<summary>
        /// Allow to set notifications settings for group.
        ///</summary>
        public Task<BaseOkResponse> SetCallbackSettings(int? groupId = null, int? serverId = null, String apiVersion = null, Boolean? messageNew = null, Boolean? messageReply = null, Boolean? messageAllow = null, Boolean? messageEdit = null, Boolean? messageDeny = null, Boolean? messageTypingState = null, Boolean? photoNew = null, Boolean? audioNew = null, Boolean? videoNew = null, Boolean? wallReplyNew = null, Boolean? wallReplyEdit = null, Boolean? wallReplyDelete = null, Boolean? wallReplyRestore = null, Boolean? wallPostNew = null, Boolean? wallRepost = null, Boolean? boardPostNew = null, Boolean? boardPostEdit = null, Boolean? boardPostRestore = null, Boolean? boardPostDelete = null, Boolean? photoCommentNew = null, Boolean? photoCommentEdit = null, Boolean? photoCommentDelete = null, Boolean? photoCommentRestore = null, Boolean? videoCommentNew = null, Boolean? videoCommentEdit = null, Boolean? videoCommentDelete = null, Boolean? videoCommentRestore = null, Boolean? marketCommentNew = null, Boolean? marketCommentEdit = null, Boolean? marketCommentDelete = null, Boolean? marketCommentRestore = null, Boolean? pollVoteNew = null, Boolean? groupJoin = null, Boolean? groupLeave = null, Boolean? groupChangeSettings = null, Boolean? groupChangePhoto = null, Boolean? groupOfficersEdit = null, Boolean? userBlock = null, Boolean? userUnblock = null, Boolean? leadFormsNew = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (serverId != null)
                parameters.Add("server_id", serverId.ToApiString());
            if (apiVersion != null)
                parameters.Add("api_version", apiVersion.ToApiString());
            if (messageNew != null)
                parameters.Add("message_new", messageNew.ToApiString());
            if (messageReply != null)
                parameters.Add("message_reply", messageReply.ToApiString());
            if (messageAllow != null)
                parameters.Add("message_allow", messageAllow.ToApiString());
            if (messageEdit != null)
                parameters.Add("message_edit", messageEdit.ToApiString());
            if (messageDeny != null)
                parameters.Add("message_deny", messageDeny.ToApiString());
            if (messageTypingState != null)
                parameters.Add("message_typing_state", messageTypingState.ToApiString());
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
            if (wallReplyDelete != null)
                parameters.Add("wall_reply_delete", wallReplyDelete.ToApiString());
            if (wallReplyRestore != null)
                parameters.Add("wall_reply_restore", wallReplyRestore.ToApiString());
            if (wallPostNew != null)
                parameters.Add("wall_post_new", wallPostNew.ToApiString());
            if (wallRepost != null)
                parameters.Add("wall_repost", wallRepost.ToApiString());
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
            if (photoCommentEdit != null)
                parameters.Add("photo_comment_edit", photoCommentEdit.ToApiString());
            if (photoCommentDelete != null)
                parameters.Add("photo_comment_delete", photoCommentDelete.ToApiString());
            if (photoCommentRestore != null)
                parameters.Add("photo_comment_restore", photoCommentRestore.ToApiString());
            if (videoCommentNew != null)
                parameters.Add("video_comment_new", videoCommentNew.ToApiString());
            if (videoCommentEdit != null)
                parameters.Add("video_comment_edit", videoCommentEdit.ToApiString());
            if (videoCommentDelete != null)
                parameters.Add("video_comment_delete", videoCommentDelete.ToApiString());
            if (videoCommentRestore != null)
                parameters.Add("video_comment_restore", videoCommentRestore.ToApiString());
            if (marketCommentNew != null)
                parameters.Add("market_comment_new", marketCommentNew.ToApiString());
            if (marketCommentEdit != null)
                parameters.Add("market_comment_edit", marketCommentEdit.ToApiString());
            if (marketCommentDelete != null)
                parameters.Add("market_comment_delete", marketCommentDelete.ToApiString());
            if (marketCommentRestore != null)
                parameters.Add("market_comment_restore", marketCommentRestore.ToApiString());
            if (pollVoteNew != null)
                parameters.Add("poll_vote_new", pollVoteNew.ToApiString());
            if (groupJoin != null)
                parameters.Add("group_join", groupJoin.ToApiString());
            if (groupLeave != null)
                parameters.Add("group_leave", groupLeave.ToApiString());
            if (groupChangeSettings != null)
                parameters.Add("group_change_settings", groupChangeSettings.ToApiString());
            if (groupChangePhoto != null)
                parameters.Add("group_change_photo", groupChangePhoto.ToApiString());
            if (groupOfficersEdit != null)
                parameters.Add("group_officers_edit", groupOfficersEdit.ToApiString());
            if (userBlock != null)
                parameters.Add("user_block", userBlock.ToApiString());
            if (userUnblock != null)
                parameters.Add("user_unblock", userUnblock.ToApiString());
            if (leadFormsNew != null)
                parameters.Add("lead_forms_new", leadFormsNew.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("groups.setCallbackSettings", parameters);
        }

        ///<summary>
        /// Sets Long Poll notification settings
        ///</summary>
        public Task<BaseOkResponse> SetLongPollSettings(int? groupId = null, Boolean? enabled = null, String apiVersion = null, Boolean? messageNew = null, Boolean? messageReply = null, Boolean? messageAllow = null, Boolean? messageDeny = null, Boolean? messageEdit = null, Boolean? messageTypingState = null, Boolean? photoNew = null, Boolean? audioNew = null, Boolean? videoNew = null, Boolean? wallReplyNew = null, Boolean? wallReplyEdit = null, Boolean? wallReplyDelete = null, Boolean? wallReplyRestore = null, Boolean? wallPostNew = null, Boolean? wallRepost = null, Boolean? boardPostNew = null, Boolean? boardPostEdit = null, Boolean? boardPostRestore = null, Boolean? boardPostDelete = null, Boolean? photoCommentNew = null, Boolean? photoCommentEdit = null, Boolean? photoCommentDelete = null, Boolean? photoCommentRestore = null, Boolean? videoCommentNew = null, Boolean? videoCommentEdit = null, Boolean? videoCommentDelete = null, Boolean? videoCommentRestore = null, Boolean? marketCommentNew = null, Boolean? marketCommentEdit = null, Boolean? marketCommentDelete = null, Boolean? marketCommentRestore = null, Boolean? pollVoteNew = null, Boolean? groupJoin = null, Boolean? groupLeave = null, Boolean? groupChangeSettings = null, Boolean? groupChangePhoto = null, Boolean? groupOfficersEdit = null, Boolean? userBlock = null, Boolean? userUnblock = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (enabled != null)
                parameters.Add("enabled", enabled.ToApiString());
            if (apiVersion != null)
                parameters.Add("api_version", apiVersion.ToApiString());
            if (messageNew != null)
                parameters.Add("message_new", messageNew.ToApiString());
            if (messageReply != null)
                parameters.Add("message_reply", messageReply.ToApiString());
            if (messageAllow != null)
                parameters.Add("message_allow", messageAllow.ToApiString());
            if (messageDeny != null)
                parameters.Add("message_deny", messageDeny.ToApiString());
            if (messageEdit != null)
                parameters.Add("message_edit", messageEdit.ToApiString());
            if (messageTypingState != null)
                parameters.Add("message_typing_state", messageTypingState.ToApiString());
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
            if (wallReplyDelete != null)
                parameters.Add("wall_reply_delete", wallReplyDelete.ToApiString());
            if (wallReplyRestore != null)
                parameters.Add("wall_reply_restore", wallReplyRestore.ToApiString());
            if (wallPostNew != null)
                parameters.Add("wall_post_new", wallPostNew.ToApiString());
            if (wallRepost != null)
                parameters.Add("wall_repost", wallRepost.ToApiString());
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
            if (photoCommentEdit != null)
                parameters.Add("photo_comment_edit", photoCommentEdit.ToApiString());
            if (photoCommentDelete != null)
                parameters.Add("photo_comment_delete", photoCommentDelete.ToApiString());
            if (photoCommentRestore != null)
                parameters.Add("photo_comment_restore", photoCommentRestore.ToApiString());
            if (videoCommentNew != null)
                parameters.Add("video_comment_new", videoCommentNew.ToApiString());
            if (videoCommentEdit != null)
                parameters.Add("video_comment_edit", videoCommentEdit.ToApiString());
            if (videoCommentDelete != null)
                parameters.Add("video_comment_delete", videoCommentDelete.ToApiString());
            if (videoCommentRestore != null)
                parameters.Add("video_comment_restore", videoCommentRestore.ToApiString());
            if (marketCommentNew != null)
                parameters.Add("market_comment_new", marketCommentNew.ToApiString());
            if (marketCommentEdit != null)
                parameters.Add("market_comment_edit", marketCommentEdit.ToApiString());
            if (marketCommentDelete != null)
                parameters.Add("market_comment_delete", marketCommentDelete.ToApiString());
            if (marketCommentRestore != null)
                parameters.Add("market_comment_restore", marketCommentRestore.ToApiString());
            if (pollVoteNew != null)
                parameters.Add("poll_vote_new", pollVoteNew.ToApiString());
            if (groupJoin != null)
                parameters.Add("group_join", groupJoin.ToApiString());
            if (groupLeave != null)
                parameters.Add("group_leave", groupLeave.ToApiString());
            if (groupChangeSettings != null)
                parameters.Add("group_change_settings", groupChangeSettings.ToApiString());
            if (groupChangePhoto != null)
                parameters.Add("group_change_photo", groupChangePhoto.ToApiString());
            if (groupOfficersEdit != null)
                parameters.Add("group_officers_edit", groupOfficersEdit.ToApiString());
            if (userBlock != null)
                parameters.Add("user_block", userBlock.ToApiString());
            if (userUnblock != null)
                parameters.Add("user_unblock", userUnblock.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("groups.setLongPollSettings", parameters);
        }
    }
}