using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Friends;
using VkApi.Wrapper.Types.Base;
using VkApi.Wrapper.Types.Friends;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Methods
{
    public class Friends
    {
        private readonly Vkontakte _vkontakte;

        internal Friends(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Approves or creates a friend request.
        ///</summary>
        public Task<int> Add(int? userId = null, String text = null, Boolean? follow = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (text != null)
                parameters.Add("text", text.ToApiString());
            if (follow != null)
                parameters.Add("follow", follow.ToApiString());
            return _vkontakte.RequestAsync<int>("friends.add", parameters);
        }

        ///<summary>
        /// Creates a new friend list for the current user.
        ///</summary>
        public Task<FriendsAddListResponse> AddList(String name = null, int[] userIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (name != null)
                parameters.Add("name", name.ToApiString());
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            return _vkontakte.RequestAsync<FriendsAddListResponse>("friends.addList", parameters);
        }

        ///<summary>
        /// Checks the current user's friendship status with other specified users.
        ///</summary>
        public Task<FriendsFriendStatus[]> AreFriends(int[] userIds = null, Boolean? needSign = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (needSign != null)
                parameters.Add("need_sign", needSign.ToApiString());
            return _vkontakte.RequestAsync<FriendsFriendStatus[]>("friends.areFriends", parameters);
        }

        ///<summary>
        /// Declines a friend request or deletes a user from the current user's friend list.
        ///</summary>
        public Task<FriendsDeleteResponse> Delete(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            return _vkontakte.RequestAsync<FriendsDeleteResponse>("friends.delete", parameters);
        }

        ///<summary>
        /// Marks all incoming friend requests as viewed.
        ///</summary>
        public Task<BaseOkResponse> DeleteAllRequests()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<BaseOkResponse>("friends.deleteAllRequests", parameters);
        }

        ///<summary>
        /// Deletes a friend list of the current user.
        ///</summary>
        public Task<BaseOkResponse> DeleteList(int? listId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (listId != null)
                parameters.Add("list_id", listId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("friends.deleteList", parameters);
        }

        ///<summary>
        /// Edits the friend lists of the selected user.
        ///</summary>
        public Task<BaseOkResponse> Edit(int? userId = null, int[] listIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (listIds != null)
                parameters.Add("list_ids", listIds.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("friends.edit", parameters);
        }

        ///<summary>
        /// Edits a friend list of the current user.
        ///</summary>
        public Task<BaseOkResponse> EditList(String name = null, int? listId = null, int[] userIds = null, int[] addUserIds = null, int[] deleteUserIds = null)
        {
            var parameters = new Dictionary<string, string>();
            if (name != null)
                parameters.Add("name", name.ToApiString());
            if (listId != null)
                parameters.Add("list_id", listId.ToApiString());
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (addUserIds != null)
                parameters.Add("add_user_ids", addUserIds.ToApiString());
            if (deleteUserIds != null)
                parameters.Add("delete_user_ids", deleteUserIds.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("friends.editList", parameters);
        }

        ///<summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        ///</summary>
        public Task<FriendsGetResponse> Get(int? userId = null, String order = null, int? listId = null, int? count = null, int? offset = null, UsersFields[] fields = null, String nameCase = null, String _ref = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (order != null)
                parameters.Add("order", order.ToApiString());
            if (listId != null)
                parameters.Add("list_id", listId.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase.ToApiString());
            if (_ref != null)
                parameters.Add("ref", _ref.ToApiString());
            return _vkontakte.RequestAsync<FriendsGetResponse>("friends.get", parameters);
        }

        ///<summary>
        /// Returns a list of IDs of the current user's friends who installed the application.
        ///</summary>
        public Task<int[]> GetAppUsers()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<int[]>("friends.getAppUsers", parameters);
        }

        ///<summary>
        /// Returns a list of the current user's friends whose phone numbers, validated or specified in a profile, are in a given list.
        ///</summary>
        public Task<FriendsUserXtrPhone[]> GetByPhones(String[] phones = null, UsersFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (phones != null)
                parameters.Add("phones", phones.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<FriendsUserXtrPhone[]>("friends.getByPhones", parameters);
        }

        ///<summary>
        /// Returns a list of the user's friend lists.
        ///</summary>
        public Task<FriendsGetListsResponse> GetLists(int? userId = null, Boolean? returnSystem = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (returnSystem != null)
                parameters.Add("return_system", returnSystem.ToApiString());
            return _vkontakte.RequestAsync<FriendsGetListsResponse>("friends.getLists", parameters);
        }

        ///<summary>
        /// Returns a list of user IDs of the mutual friends of two users.
        ///</summary>
        public Task<int[]> GetMutual(int? sourceUid = null, int? targetUid = null, int[] targetUids = null, String order = null, int? count = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();
            if (sourceUid != null)
                parameters.Add("source_uid", sourceUid.ToApiString());
            if (targetUid != null)
                parameters.Add("target_uid", targetUid.ToApiString());
            if (targetUids != null)
                parameters.Add("target_uids", targetUids.ToApiString());
            if (order != null)
                parameters.Add("order", order.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            return _vkontakte.RequestAsync<int[]>("friends.getMutual", parameters);
        }

        ///<summary>
        /// Returns a list of user IDs of a user's friends who are online.
        ///</summary>
        public Task<int[]> GetOnline(int? userId = null, int? listId = null, Boolean? onlineMobile = null, String order = null, int? count = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (listId != null)
                parameters.Add("list_id", listId.ToApiString());
            if (onlineMobile != null)
                parameters.Add("online_mobile", onlineMobile.ToApiString());
            if (order != null)
                parameters.Add("order", order.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            return _vkontakte.RequestAsync<int[]>("friends.getOnline", parameters);
        }

        ///<summary>
        /// Returns a list of user IDs of the current user's recently added friends.
        ///</summary>
        public Task<int[]> GetRecent(int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<int[]>("friends.getRecent", parameters);
        }

        ///<summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        ///</summary>
        public Task<FriendsGetRequestsResponse> GetRequests(int? offset = null, int? count = null, Boolean? extended = null, Boolean? needMutual = null, Boolean? _out = null, int? sort = null, Boolean? needViewed = null, Boolean? suggested = null, String _ref = null, UsersFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (needMutual != null)
                parameters.Add("need_mutual", needMutual.ToApiString());
            if (_out != null)
                parameters.Add("out", _out.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (needViewed != null)
                parameters.Add("need_viewed", needViewed.ToApiString());
            if (suggested != null)
                parameters.Add("suggested", suggested.ToApiString());
            if (_ref != null)
                parameters.Add("ref", _ref.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<FriendsGetRequestsResponse>("friends.getRequests", parameters);
        }

        ///<summary>
        /// Returns a list of profiles of users whom the current user may know.
        ///</summary>
        public Task<FriendsGetSuggestionsResponse> GetSuggestions(String[] filter = null, int? count = null, int? offset = null, UsersFields[] fields = null, String nameCase = null)
        {
            var parameters = new Dictionary<string, string>();
            if (filter != null)
                parameters.Add("filter", filter.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase.ToApiString());
            return _vkontakte.RequestAsync<FriendsGetSuggestionsResponse>("friends.getSuggestions", parameters);
        }

        ///<summary>
        /// Returns a list of friends matching the search criteria.
        ///</summary>
        public Task<FriendsSearchResponse> Search(int? userId = null, String q = null, UsersFields[] fields = null, String nameCase = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            return _vkontakte.RequestAsync<FriendsSearchResponse>("friends.search", parameters);
        }
    }
}