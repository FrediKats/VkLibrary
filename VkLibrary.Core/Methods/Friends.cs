using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Friends;
using VkLibrary.Core.Types.Friends;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Friends API section.
    /// </summary>
    public class Friends
    {
        private readonly Vkontakte _vkontakte;

        internal Friends(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// Docs: <see href="https://vk.com/dev/friends.get">friends.get</see>
        /// </summary>
        /// <param name="userId">User ID. By default, the current user ID.</param>
        /// <param name="order">
        /// Sort order: ; 'name' — by name (enabled only if the 'fields' parameter is used); 'hints' — by
        /// rating, similar to how friends are sorted in My friends section; ; This parameter is available only for
        /// [vk.com/dev/standalone|desktop applications].
        /// </param>
        /// <param name="listId">
        /// ID of the friend list returned by the [vk.com/dev/friends.getLists|friends.getLists] method to be
        /// used as the source. This parameter is taken into account only when the uid parameter is set to the current user
        /// ID.; ; This parameter is available only for [vk.com/dev/standalone|desktop applications].
        /// </param>
        /// <param name="count">Number of friends to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of friends.</param>
        /// <param name="fields">
        /// Profile fields to return. Sample values: 'uid', 'first_name', 'last_name', 'nickname', 'sex',
        /// 'bdate' (birthdate), 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'domain', 'has_mobile',
        /// 'rate', 'contacts', 'education'.;
        /// </param>
        /// <param name="nameCase">
        /// Case for declension of user name and surname: ; 'nom' — nominative (default) ; 'gen' — genitive
        /// ; 'dat' — dative ; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional
        /// </param>
        public async Task<ApiItemsResponse<UserFull>> Get(int? userId = null, string order = null, int? listId = null,
            int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (order != null)
                parameters.Add("order", order);
            if (listId != null)
                parameters.Add("list_id", listId.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase);

            return await _vkontakte.GetAsync<ApiItemsResponse<UserFull>>("friends.get", parameters);
        }

        /// <summary>
        /// Returns a list of user IDs of a user's friends who are online.
        /// Docs: <see href="https://vk.com/dev/friends.getOnline">friends.getOnline</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="listId">Friend list ID. If this parameter is not set, information about all online friends is returned.</param>
        /// <param name="onlineMobile">'1' — to return an additional 'online_mobile' field; '0' — (default);</param>
        /// <param name="order">Sort order:; 'random' — random order</param>
        /// <param name="count">Number of friends to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of friends.</param>
        public async Task<IEnumerable<int?>> GetOnline(int? userId = null, int? listId = null,
            bool? onlineMobile = null, string order = null, int? count = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (listId != null)
                parameters.Add("list_id", listId.ToApiString());
            if (onlineMobile != null)
                parameters.Add("online_mobile", onlineMobile.ToApiString());
            if (order != null)
                parameters.Add("order", order);
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<int?>>("friends.getOnline", parameters);
        }

        /// <summary>
        /// Returns a list of user IDs of the mutual friends of two users.
        /// Docs: <see href="https://vk.com/dev/friends.getMutual">friends.getMutual</see>
        /// </summary>
        /// <param name="sourceUid">
        /// ID of the user whose friends will be checked against the friends of the user specified in
        /// 'target_uid'.
        /// </param>
        /// <param name="targetUid">
        /// ID of the user whose friends will be checked against the friends of the user specified in
        /// 'source_uid'.
        /// </param>
        /// <param name="targetUids">
        /// IDs of the users whose friends will be checked against the friends of the user specified in
        /// 'source_uid'.
        /// </param>
        /// <param name="order">Sort order:; 'random' — random order</param>
        /// <param name="count">Number of mutual friends to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of mutual friends.</param>
        public async Task<IEnumerable<int?>> GetMutual(int? sourceUid = null, int? targetUid = null,
            IEnumerable<int?> targetUids = null, string order = null, int? count = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();

            if (sourceUid != null)
                parameters.Add("source_uid", sourceUid.ToApiString());
            if (targetUid != null)
                parameters.Add("target_uid", targetUid.ToApiString());
            if (targetUids != null)
                parameters.Add("target_uids", targetUids.ToApiString());
            if (order != null)
                parameters.Add("order", order);
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<int?>>("friends.getMutual", parameters);
        }

        /// <summary>
        /// Returns a list of user IDs of the current user's recently added friends.
        /// Docs: <see href="https://vk.com/dev/friends.getRecent">friends.getRecent</see>
        /// </summary>
        /// <param name="count">Number of recently added friends to return.</param>
        public async Task<IEnumerable<int?>> GetRecent(int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<int?>>("friends.getRecent", parameters);
        }

        /// <summary>
        /// Returns information about the current user's incoming and outgoing friend requests.
        /// Docs: <see href="https://vk.com/dev/friends.getRequests">friends.getRequests</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of friend requests.</param>
        /// <param name="count">Number of friend requests to return (default 100, maximum 1000).</param>
        /// <param name="needViewed">
        /// '1' — to return response messages from users who have sent a friend request or, if 'suggested'
        /// is set to '1', to return a list of suggested friends
        /// </param>
        /// <param name="needMutual">'1' — to return a list of mutual friends (up to 20), if any</param>
        /// <param name="out_">'1' — to return outgoing requests; '0' — to return incoming requests (default)</param>
        /// <param name="sort">Sort order:; '1' — by number of mutual friends; '0' — by date</param>
        /// <param name="suggested">'1' — to return a list of suggested friends; '0' — to return friend requests (default)</param>
        public async Task<ApiItemsResponse<T>> GetRequests<T>(bool? needViewed = null, int? offset = null,
            int? count = null, bool? needMutual = null, bool? out_ = null, int? sort = null, bool? suggested = null)
        {
            var parameters = new Dictionary<string, string>();

            if (needViewed != null)
                parameters.Add("need_viewed", needViewed.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            parameters.Add("extended", 1.ToApiString());

            if (needMutual != null)
                parameters.Add("need_mutual", needMutual.ToApiString());
            if (out_ != null)
                parameters.Add("out", out_.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (suggested != null)
                parameters.Add("suggested", suggested.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<T>>("friends.getRequests", parameters);
        }

        /// <summary>
        /// Approves or creates a friend request.
        /// Docs: <see href="https://vk.com/dev/friends.add">friends.add</see>
        /// </summary>
        /// <param name="userId">ID of the user whose friend request will be approved or to whom a friend request will be sent.</param>
        /// <param name="text">Text of the message (up to 500 characters) for the friend request, if any.</param>
        /// <param name="follow">'1' to pass an incoming request to followers list.</param>
        public async Task<int?> Add(int? userId = null, string text = null, bool? follow = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (text != null)
                parameters.Add("text", text);
            if (follow != null)
                parameters.Add("follow", follow.ToApiString());

            return await _vkontakte.GetAsync<int?>("friends.add", parameters);
        }

        /// <summary>
        /// Edits the friend lists of the selected user.
        /// Docs: <see href="https://vk.com/dev/friends.edit">friends.edit</see>
        /// </summary>
        /// <param name="userId">ID of the user whose friend list is to be edited.</param>
        /// <param name="listIds">IDs of the friend lists to which to add the user.</param>
        public async Task<int> Edit(int? userId = null, IEnumerable<int?> listIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (listIds != null)
                parameters.Add("list_ids", listIds.ToApiString());

            return await _vkontakte.GetAsync<int>("friends.edit", parameters);
        }

        /// <summary>
        /// Declines a friend request or deletes a user from the current user's friend list.
        /// Docs: <see href="https://vk.com/dev/friends.delete">friends.delete</see>
        /// </summary>
        /// <param name="userId">
        /// ID of the user whose friend request is to be declined or who is to be deleted from the current
        /// user's friend list.
        /// </param>
        public async Task<DeleteResponse> Delete(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<DeleteResponse>("friends.delete", parameters);
        }

        /// <summary>
        /// Returns a list of the user's friend lists.
        /// Docs: <see href="https://vk.com/dev/friends.getLists">friends.getLists</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="returnSystem">'1' — to return system friend lists. By default: '0'.</param>
        public async Task<ApiItemsResponse<FriendsList>> GetLists(int? userId = null, bool? returnSystem = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (returnSystem != null)
                parameters.Add("return_system", returnSystem.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<FriendsList>>("friends.getLists", parameters);
        }

        /// <summary>
        /// Creates a new friend list for the current user.
        /// Docs: <see href="https://vk.com/dev/friends.addList">friends.addList</see>
        /// </summary>
        /// <param name="name">Name of the friend list.</param>
        /// <param name="userIds">IDs of users to be added to the friend list.;</param>
        public async Task<AddListResponse> AddList(string name = null, IEnumerable<int?> userIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (name != null)
                parameters.Add("name", name);
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());

            return await _vkontakte.GetAsync<AddListResponse>("friends.addList", parameters);
        }

        /// <summary>
        /// Edits a friend list of the current user.
        /// Docs: <see href="https://vk.com/dev/friends.editList">friends.editList</see>
        /// </summary>
        /// <param name="name">Name of the friend list.</param>
        /// <param name="listId">Friend list ID.</param>
        /// <param name="userIds">IDs of users in the friend list.</param>
        /// <param name="addUserIds">(Applies if 'user_ids' parameter is not set.); User IDs to add to the friend list.</param>
        /// <param name="deleteUserIds">(Applies if 'user_ids' parameter is not set.); User IDs to delete from the friend list.</param>
        public async Task<int> EditList(string name = null, int? listId = null, IEnumerable<int?> userIds = null,
            IEnumerable<int?> addUserIds = null, IEnumerable<int?> deleteUserIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (name != null)
                parameters.Add("name", name);
            if (listId != null)
                parameters.Add("list_id", listId.ToApiString());
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (addUserIds != null)
                parameters.Add("add_user_ids", addUserIds.ToApiString());
            if (deleteUserIds != null)
                parameters.Add("delete_user_ids", deleteUserIds.ToApiString());

            return await _vkontakte.GetAsync<int>("friends.editList", parameters);
        }

        /// <summary>
        /// Deletes a friend list of the current user.
        /// Docs: <see href="https://vk.com/dev/friends.deleteList">friends.deleteList</see>
        /// </summary>
        /// <param name="listId">ID of the friend list to delete.</param>
        public async Task<int> DeleteList(int? listId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (listId != null)
                parameters.Add("list_id", listId.ToApiString());

            return await _vkontakte.GetAsync<int>("friends.deleteList", parameters);
        }

        /// <summary>
        /// Returns a list of IDs of the current user's friends who installed the application.
        /// Docs: <see href="https://vk.com/dev/friends.getAppUsers">friends.getAppUsers</see>
        /// </summary>
        public async Task<IEnumerable<int?>> GetAppUsers()
        {
            var parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<IEnumerable<int?>>("friends.getAppUsers", parameters);
        }

        /// <summary>
        /// Returns a list of the current user's friends whose phone numbers, validated or specified in a profile, are in a
        /// given list.
        /// Docs: <see href="https://vk.com/dev/friends.getByPhones">friends.getByPhones</see>
        /// </summary>
        /// <param name="phones">List of phone numbers in MSISDN format (maximum 1000).; Example:; "+79219876543,+79111234567"</param>
        /// <param name="fields">
        /// Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate' (birthdate),
        /// 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'rate', 'contacts', 'education',
        /// 'online, counters'.;
        /// </param>
        public async Task<IEnumerable<UserXtrPhone>> GetByPhones(IEnumerable<string> phones = null,
            IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (phones != null)
                parameters.Add("phones", phones.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<UserXtrPhone>>("friends.getByPhones", parameters);
        }

        /// <summary>
        /// Marks all incoming friend requests as viewed.
        /// Docs: <see href="https://vk.com/dev/friends.deleteAllRequests">friends.deleteAllRequests</see>
        /// </summary>
        public async Task<int> DeleteAllRequests()
        {
            var parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<int>("friends.deleteAllRequests", parameters);
        }

        /// <summary>
        /// Returns a list of profiles of users whom the current user may know.
        /// Docs: <see href="https://vk.com/dev/friends.getSuggestions">friends.getSuggestions</see>
        /// </summary>
        /// <param name="filter">
        /// Types of potential friends to return:; 'mutual' — users with many mutual friends ; 'contacts' —
        /// users found with the [vk.com/dev/account.importContacts|account.importContacts] method ; 'mutual_contacts' — users
        /// who imported the same contacts as the current user with the
        /// [vk.com/dev/account.importContacts|account.importContacts] method
        /// </param>
        /// <param name="count">Number of suggestions to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of suggestions.</param>
        /// <param name="fields">
        /// Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate' (birthdate),
        /// 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'rate', 'contacts', 'education',
        /// 'online', 'counters'.;
        /// </param>
        /// <param name="nameCase">
        /// Case for declension of user name and surname: ; 'nom' — nominative (default) ; 'gen' — genitive
        /// ; 'dat' — dative ; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional
        /// </param>
        public async Task<ApiItemsResponse<UserFull>> GetSuggestions(IEnumerable<string> filter = null,
            int? count = null, int? offset = null, IEnumerable<string> fields = null, string nameCase = null)
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
                parameters.Add("name_case", nameCase);

            return await _vkontakte.GetAsync<ApiItemsResponse<UserFull>>("friends.getSuggestions", parameters);
        }

        /// <summary>
        /// Checks the current user's friendship status with other specified users.
        /// Docs: <see href="https://vk.com/dev/friends.areFriends">friends.areFriends</see>
        /// </summary>
        /// <param name="userIds">IDs of the users whose friendship status to check.</param>
        /// <param name="needSign">
        /// '1' — to return 'sign' field. 'sign' is
        /// md5("{id}_{user_id}_{friends_status}_{application_secret}"), where id is current user ID.; This field allows to
        /// check that data has not been modified by the client.; By default: '0'.
        /// </param>
        public async Task<IEnumerable<FriendStatus>> AreFriends(IEnumerable<int?> userIds = null,
            bool? needSign = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (needSign != null)
                parameters.Add("need_sign", needSign.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<FriendStatus>>("friends.areFriends", parameters);
        }

        /// <summary>
        /// Returns a list of friends who can be called by the current user.
        /// Docs: <see href="https://vk.com/dev/friends.getAvailableForCall">friends.getAvailableForCall</see>
        /// </summary>
        /// <param name="fields">
        /// Profile fields to return. Sample values: 'uid', 'first_name', 'last_name', 'nickname', 'sex',
        /// 'bdate' (birthdate), 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'domain', 'has_mobile',
        /// 'rate', 'contacts', 'education'.;
        /// </param>
        /// <param name="nameCase">
        /// Case for declension of user name and surname: ; 'nom' — nominative (default) ; 'gen' — genitive
        /// ; 'dat' — dative ; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional
        /// </param>
        public async Task<ApiItemsResponse<int?>> GetAvailableForCall(IEnumerable<string> fields = null,
            string nameCase = null)
        {
            var parameters = new Dictionary<string, string>();

            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase);

            return await _vkontakte.GetAsync<ApiItemsResponse<int?>>("friends.getAvailableForCall", parameters);
        }

        /// <summary>
        /// Returns a list of friends matching the search criteria.
        /// Docs: <see href="https://vk.com/dev/friends.search">friends.search</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="q">Search query string (e.g., 'Vasya Babich').</param>
        /// <param name="fields">
        /// Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate' (birthdate),
        /// 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'rate', 'contacts', 'education',
        /// 'online';
        /// </param>
        /// <param name="nameCase">
        /// Case for declension of user name and surname:; 'nom' — nominative (default); 'gen' — genitive ;
        /// 'dat' — dative; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional
        /// </param>
        /// <param name="offset">Offset needed to return a specific subset of friends.</param>
        /// <param name="count">Number of friends to return.</param>
        public async Task<ApiItemsResponse<UserFull>> Search(int? userId = null, string q = null,
            IEnumerable<string> fields = null, string nameCase = null, int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (q != null)
                parameters.Add("q", q);
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase);
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<UserFull>>("friends.search", parameters);
        }
    }
}