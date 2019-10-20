using VkLibrary.Core.Objects;
using VkLibrary.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Methods
{
    public class Newsfeed
    {
        private readonly Vkontakte _vkontakte;

        internal Newsfeed(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Prevents news from specified users and communities from appearing in the current user's newsfeed.
        ///</summary>
        public Task<BaseOkResponse> AddBan(int[] userIds = null, int[] groupIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (groupIds != null)
                parameters.Add("group_ids", groupIds.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("newsfeed.addBan", parameters);
        }

        ///<summary>
        /// Allows news from previously banned users and communities to be shown in the current user's newsfeed.
        ///</summary>
        public Task<BaseOkResponse> DeleteBan(int[] userIds = null, int[] groupIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (groupIds != null)
                parameters.Add("group_ids", groupIds.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("newsfeed.deleteBan", parameters);
        }

        ///<summary>
        /// Returns data required to show newsfeed for the current user.
        ///</summary>
        public Task<NewsfeedGetResponse> Get(NewsfeedFilters[] filters = null, Boolean? returnBanned = null, int? startTime = null, int? endTime = null, int? maxPhotos = null, String sourceIds = null, String startFrom = null, int? count = null, BaseUserGroupFields[] fields = null, String section = null)
        {
            var parameters = new Dictionary<string, string>();
            if (filters != null)
                parameters.Add("filters", filters.ToApiString());
            if (returnBanned != null)
                parameters.Add("return_banned", returnBanned.ToApiString());
            if (startTime != null)
                parameters.Add("start_time", startTime.ToApiString());
            if (endTime != null)
                parameters.Add("end_time", endTime.ToApiString());
            if (maxPhotos != null)
                parameters.Add("max_photos", maxPhotos.ToApiString());
            if (sourceIds != null)
                parameters.Add("source_ids", sourceIds.ToApiString());
            if (startFrom != null)
                parameters.Add("start_from", startFrom.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (section != null)
                parameters.Add("section", section.ToApiString());
            return _vkontakte.RequestAsync<NewsfeedGetResponse>("newsfeed.get", parameters);
        }

        ///<summary>
        /// Returns a list of users and communities banned from the current user's newsfeed.
        ///</summary>
        public Task<NewsfeedGetBannedResponse> GetBanned(Boolean? extended = null, UsersFields[] fields = null, String nameCase = null)
        {
            var parameters = new Dictionary<string, string>();
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase.ToApiString());
            return _vkontakte.RequestAsync<NewsfeedGetBannedResponse>("newsfeed.getBanned", parameters);
        }

        ///<summary>
        /// Returns a list of comments in the current user's newsfeed.
        ///</summary>
        public Task<NewsfeedGetCommentsResponse> GetComments(int? count = null, NewsfeedCommentsFilters[] filters = null, String reposts = null, int? startTime = null, int? endTime = null, int? lastCommentsCount = null, String startFrom = null, BaseUserGroupFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (filters != null)
                parameters.Add("filters", filters.ToApiString());
            if (reposts != null)
                parameters.Add("reposts", reposts.ToApiString());
            if (startTime != null)
                parameters.Add("start_time", startTime.ToApiString());
            if (endTime != null)
                parameters.Add("end_time", endTime.ToApiString());
            if (lastCommentsCount != null)
                parameters.Add("last_comments_count", lastCommentsCount.ToApiString());
            if (startFrom != null)
                parameters.Add("start_from", startFrom.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<NewsfeedGetCommentsResponse>("newsfeed.getComments", parameters);
        }

        ///<summary>
        /// Returns a list of newsfeeds followed by the current user.
        ///</summary>
        public Task<NewsfeedGetListsResponse> GetLists(int[] listIds = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (listIds != null)
                parameters.Add("list_ids", listIds.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<NewsfeedGetListsResponse>("newsfeed.getLists", parameters);
        }

        ///<summary>
        /// Returns a list of posts on user walls in which the current user is mentioned.
        ///</summary>
        public Task<NewsfeedGetMentionsResponse> GetMentions(int? ownerId = null, int? startTime = null, int? endTime = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (startTime != null)
                parameters.Add("start_time", startTime.ToApiString());
            if (endTime != null)
                parameters.Add("end_time", endTime.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<NewsfeedGetMentionsResponse>("newsfeed.getMentions", parameters);
        }

        ///<summary>
        /// , Returns a list of newsfeeds recommended to the current user.
        ///</summary>
        public Task<NewsfeedGetRecommendedResponse> GetRecommended(int? startTime = null, int? endTime = null, int? maxPhotos = null, String startFrom = null, int? count = null, BaseUserGroupFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (startTime != null)
                parameters.Add("start_time", startTime.ToApiString());
            if (endTime != null)
                parameters.Add("end_time", endTime.ToApiString());
            if (maxPhotos != null)
                parameters.Add("max_photos", maxPhotos.ToApiString());
            if (startFrom != null)
                parameters.Add("start_from", startFrom.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<NewsfeedGetRecommendedResponse>("newsfeed.getRecommended", parameters);
        }

        ///<summary>
        /// Hides an item from the newsfeed.
        ///</summary>
        public Task<BaseOkResponse> IgnoreItem(String type = null, int? ownerId = null, int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("newsfeed.ignoreItem", parameters);
        }

        ///<summary>
        /// Creates and edits user newsfeed lists
        ///</summary>
        public Task<int> SaveList(int? listId = null, String title = null, int[] sourceIds = null, Boolean? noReposts = null)
        {
            var parameters = new Dictionary<string, string>();
            if (listId != null)
                parameters.Add("list_id", listId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (sourceIds != null)
                parameters.Add("source_ids", sourceIds.ToApiString());
            if (noReposts != null)
                parameters.Add("no_reposts", noReposts.ToApiString());
            return _vkontakte.RequestAsync<int>("newsfeed.saveList", parameters);
        }

        ///<summary>
        /// Returns search results by statuses.
        ///</summary>
        public Task<NewsfeedSearchResponse> Search(String q = null, Boolean? extended = null, int? count = null, double? latitude = null, double? longitude = null, int? startTime = null, int? endTime = null, String startFrom = null, BaseUserGroupFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (latitude != null)
                parameters.Add("latitude", latitude.ToApiString());
            if (longitude != null)
                parameters.Add("longitude", longitude.ToApiString());
            if (startTime != null)
                parameters.Add("start_time", startTime.ToApiString());
            if (endTime != null)
                parameters.Add("end_time", endTime.ToApiString());
            if (startFrom != null)
                parameters.Add("start_from", startFrom.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<NewsfeedSearchResponse>("newsfeed.search", parameters);
        }

        ///<summary>
        /// Returns a hidden item to the newsfeed.
        ///</summary>
        public Task<BaseOkResponse> UnignoreItem(String type = null, int? ownerId = null, int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("newsfeed.unignoreItem", parameters);
        }

        ///<summary>
        /// Unsubscribes the current user from specified newsfeeds.
        ///</summary>
        public Task<BaseOkResponse> Unsubscribe(String type = null, int? ownerId = null, int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("newsfeed.unsubscribe", parameters);
        }
    }
}