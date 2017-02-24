using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Friends API section.
    /// </summary>
    public class Friends
    {
        private Vkontakte _vkontakte;

        internal Friends(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of user IDs or detailed information about a user's friends.
        /// Docs: <see href="https://vk.com/dev/friends.get">friends.get</see>
        /// </summary>
        /// <param name="user_id">User ID. By default, the current user ID.</param>
        /// <param name="order">Sort order: ; 'name' — by name (enabled only if the 'fields' parameter is used); 'hints' — by rating, similar to how friends are sorted in My friends section; ; This parameter is available only for [vk.com/dev/standalone|desktop applications].</param>
        /// <param name="list_id">ID of the friend list returned by the [vk.com/dev/friends.getLists|friends.getLists] method to be used as the source. This parameter is taken into account only when the uid parameter is set to the current user ID.; ; This parameter is available only for [vk.com/dev/standalone|desktop applications].</param>
        /// <param name="count">Number of friends to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of friends.</param>
        /// <param name="fields">Profile fields to return. Sample values: 'uid', 'first_name', 'last_name', 'nickname', 'sex', 'bdate' (birthdate), 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'domain', 'has_mobile', 'rate', 'contacts', 'education'.;</param>
        /// <param name="name_case">Case for declension of user name and surname: ; 'nom' — nominative (default) ; 'gen' — genitive ; 'dat' — dative ; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional</param>
        public async Task<ApiItemsResponse<Types.Users.UserFull>> Get(int? user_id = null, string order = null, int? list_id = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string name_case = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
            if (order != null)
                parameters.Add("order", order);
            if (list_id != null)
                parameters.Add("list_id", list_id.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (name_case != null)
                parameters.Add("name_case", name_case);

            return await _vkontakte.GetAsync<ApiItemsResponse<Types.Users.UserFull>>("friends.get", parameters);
        }

        /// <summary>
        /// Returns a list of user IDs of a user's friends who are online.
        /// Docs: <see href="https://vk.com/dev/friends.getOnline">friends.getOnline</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="list_id">Friend list ID. If this parameter is not set, information about all online friends is returned.</param>
        /// <param name="online_mobile">'1' — to return an additional 'online_mobile' field; '0' — (default);</param>
        /// <param name="order">Sort order:; 'random' — random order</param>
        /// <param name="count">Number of friends to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of friends.</param>
        public async Task<IEnumerable<int?>> GetOnline(int? user_id = null, int? list_id = null, bool? online_mobile = null, string order = null, int? count = null, int? offset = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
            if (list_id != null)
                parameters.Add("list_id", list_id.ToApiString());
            if (online_mobile != null)
                parameters.Add("online_mobile", online_mobile.ToApiString());
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
        /// <param name="source_uid">ID of the user whose friends will be checked against the friends of the user specified in 'target_uid'.</param>
        /// <param name="target_uid">ID of the user whose friends will be checked against the friends of the user specified in 'source_uid'.</param>
        /// <param name="target_uids">IDs of the users whose friends will be checked against the friends of the user specified in 'source_uid'.</param>
        /// <param name="order">Sort order:; 'random' — random order</param>
        /// <param name="count">Number of mutual friends to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of mutual friends.</param>
        public async Task<IEnumerable<int?>> GetMutual(int? source_uid = null, int? target_uid = null, IEnumerable<int?> target_uids = null, string order = null, int? count = null, int? offset = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (source_uid != null)
                parameters.Add("source_uid", source_uid.ToApiString());
            if (target_uid != null)
                parameters.Add("target_uid", target_uid.ToApiString());
            if (target_uids != null)
                parameters.Add("target_uids", target_uids.ToApiString());
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
            Dictionary<string, string> parameters = new Dictionary<string, string>();

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
        /// <param name="extended">'1' — to return response messages from users who have sent a friend request or, if 'suggested' is set to '1', to return a list of suggested friends</param>
        /// <param name="need_mutual">'1' — to return a list of mutual friends (up to 20), if any</param>
        /// <param name="out">'1' — to return outgoing requests; '0' — to return incoming requests (default)</param>
        /// <param name="sort">Sort order:; '1' — by number of mutual friends; '0' — by date</param>
        /// <param name="suggested">'1' — to return a list of suggested friends; '0' — to return friend requests (default)</param>
        public async Task<ApiItemsResponse<T>> GetRequests<T>(int? need_viewed = null, int? offset = null, int? count = null, int? need_mutual = null, int? out_ = null, int? sort = null, int? suggested = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
           
            parameters.Add("extended", 1.ToApiString());

            if (need_mutual != null)
                parameters.Add("need_mutual", need_mutual.ToApiString());
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
        /// <param name="user_id">ID of the user whose friend request will be approved or to whom a friend request will be sent.</param>
        /// <param name="text">Text of the message (up to 500 characters) for the friend request, if any.</param>
        /// <param name="follow">'1' to pass an incoming request to followers list.</param>
        public async Task<int?> Add(int? user_id = null, string text = null, bool? follow = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
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
        /// <param name="user_id">ID of the user whose friend list is to be edited.</param>
        /// <param name="list_ids">IDs of the friend lists to which to add the user.</param>
        public async Task<int> Edit(int? user_id = null, IEnumerable<int?> list_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
            if (list_ids != null)
                parameters.Add("list_ids", list_ids.ToApiString());

            return await _vkontakte.GetAsync<int>("friends.edit", parameters);
        }

        /// <summary>
        /// Declines a friend request or deletes a user from the current user's friend list.
        /// Docs: <see href="https://vk.com/dev/friends.delete">friends.delete</see>
        /// </summary>
        /// <param name="user_id">ID of the user whose friend request is to be declined or who is to be deleted from the current user's friend list.</param>
        public async Task<VkLib.Responses.Friends.DeleteResponse> Delete(int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Responses.Friends.DeleteResponse>("friends.delete", parameters);
        }

        /// <summary>
        /// Returns a list of the user's friend lists.
        /// Docs: <see href="https://vk.com/dev/friends.getLists">friends.getLists</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="return_system">'1' — to return system friend lists. By default: '0'.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Friends.FriendsList>> GetLists(int? user_id = null, bool? return_system = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
            if (return_system != null)
                parameters.Add("return_system", return_system.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Friends.FriendsList>>("friends.getLists", parameters);
        }

        /// <summary>
        /// Creates a new friend list for the current user.
        /// Docs: <see href="https://vk.com/dev/friends.addList">friends.addList</see>
        /// </summary>
        /// <param name="name">Name of the friend list.</param>
        /// <param name="user_ids">IDs of users to be added to the friend list.;</param>
        public async Task<VkLib.Responses.Friends.AddListResponse> AddList(string name = null, IEnumerable<int?> user_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (name != null)
                parameters.Add("name", name);
            if (user_ids != null)
                parameters.Add("user_ids", user_ids.ToApiString());

            return await _vkontakte.GetAsync<VkLib.Responses.Friends.AddListResponse>("friends.addList", parameters);
        }

        /// <summary>
        /// Edits a friend list of the current user.
        /// Docs: <see href="https://vk.com/dev/friends.editList">friends.editList</see>
        /// </summary>
        /// <param name="name">Name of the friend list.</param>
        /// <param name="list_id">Friend list ID.</param>
        /// <param name="user_ids">IDs of users in the friend list.</param>
        /// <param name="add_user_ids">(Applies if 'user_ids' parameter is not set.); User IDs to add to the friend list.</param>
        /// <param name="delete_user_ids">(Applies if 'user_ids' parameter is not set.); User IDs to delete from the friend list.</param>
        public async Task<int> EditList(string name = null, int? list_id = null, IEnumerable<int?> user_ids = null, IEnumerable<int?> add_user_ids = null, IEnumerable<int?> delete_user_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (name != null)
                parameters.Add("name", name);
            if (list_id != null)
                parameters.Add("list_id", list_id.ToApiString());
            if (user_ids != null)
                parameters.Add("user_ids", user_ids.ToApiString());
            if (add_user_ids != null)
                parameters.Add("add_user_ids", add_user_ids.ToApiString());
            if (delete_user_ids != null)
                parameters.Add("delete_user_ids", delete_user_ids.ToApiString());

            return await _vkontakte.GetAsync<int>("friends.editList", parameters);
        }

        /// <summary>
        /// Deletes a friend list of the current user.
        /// Docs: <see href="https://vk.com/dev/friends.deleteList">friends.deleteList</see>
        /// </summary>
        /// <param name="list_id">ID of the friend list to delete.</param>
        public async Task<int> DeleteList(int? list_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (list_id != null)
                parameters.Add("list_id", list_id.ToApiString());

            return await _vkontakte.GetAsync<int>("friends.deleteList", parameters);
        }

        /// <summary>
        /// Returns a list of IDs of the current user's friends who installed the application.
        /// Docs: <see href="https://vk.com/dev/friends.getAppUsers">friends.getAppUsers</see>
        /// </summary>
        public async Task<IEnumerable<int?>> GetAppUsers()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<IEnumerable<int?>>("friends.getAppUsers", parameters);
        }

        /// <summary>
        /// Returns a list of the current user's friends whose phone numbers, validated or specified in a profile, are in a given list.
        /// Docs: <see href="https://vk.com/dev/friends.getByPhones">friends.getByPhones</see>
        /// </summary>
        /// <param name="phones">List of phone numbers in MSISDN format (maximum 1000).; Example:; "+79219876543,+79111234567"</param>
        /// <param name="fields">Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate' (birthdate), 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'rate', 'contacts', 'education', 'online, counters'.;</param>
        public async Task<IEnumerable<VkLib.Types.Friends.UserXtrPhone>> GetByPhones(IEnumerable<string> phones = null, IEnumerable<string> fields = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (phones != null)
                parameters.Add("phones", phones.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Friends.UserXtrPhone>>("friends.getByPhones", parameters);
        }

        /// <summary>
        /// Marks all incoming friend requests as viewed.
        /// Docs: <see href="https://vk.com/dev/friends.deleteAllRequests">friends.deleteAllRequests</see>
        /// </summary>
        public async Task<int> DeleteAllRequests()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<int>("friends.deleteAllRequests", parameters);
        }

        /// <summary>
        /// Returns a list of profiles of users whom the current user may know.
        /// Docs: <see href="https://vk.com/dev/friends.getSuggestions">friends.getSuggestions</see>
        /// </summary>
        /// <param name="filter">Types of potential friends to return:; 'mutual' — users with many mutual friends ; 'contacts' — users found with the [vk.com/dev/account.importContacts|account.importContacts] method ; 'mutual_contacts' — users who imported the same contacts as the current user with the [vk.com/dev/account.importContacts|account.importContacts] method</param>
        /// <param name="count">Number of suggestions to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of suggestions.</param>
        /// <param name="fields">Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate' (birthdate), 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'rate', 'contacts', 'education', 'online', 'counters'.;</param>
        /// <param name="name_case">Case for declension of user name and surname: ; 'nom' — nominative (default) ; 'gen' — genitive ; 'dat' — dative ; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional</param>
        public async Task<ApiItemsResponse<VkLib.Types.Users.UserFull>> GetSuggestions(IEnumerable<string> filter = null, int? count = null, int? offset = null, IEnumerable<string> fields = null, string name_case = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (filter != null)
                parameters.Add("filter", filter.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (name_case != null)
                parameters.Add("name_case", name_case);

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Users.UserFull>>("friends.getSuggestions", parameters);
        }

        /// <summary>
        /// Checks the current user's friendship status with other specified users.
        /// Docs: <see href="https://vk.com/dev/friends.areFriends">friends.areFriends</see>
        /// </summary>
        /// <param name="user_ids">IDs of the users whose friendship status to check.</param>
        /// <param name="need_sign">'1' — to return 'sign' field. 'sign' is md5("{id}_{user_id}_{friends_status}_{application_secret}"), where id is current user ID.; This field allows to check that data has not been modified by the client.; By default: '0'.</param>
        public async Task<IEnumerable<VkLib.Types.Friends.FriendStatus>> AreFriends(IEnumerable<int?> user_ids = null, bool? need_sign = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_ids != null)
                parameters.Add("user_ids", user_ids.ToApiString());
            if (need_sign != null)
                parameters.Add("need_sign", need_sign.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Friends.FriendStatus>>("friends.areFriends", parameters);
        }

        /// <summary>
        /// Returns a list of friends who can be called by the current user.
        /// Docs: <see href="https://vk.com/dev/friends.getAvailableForCall">friends.getAvailableForCall</see>
        /// </summary>
        /// <param name="fields">Profile fields to return. Sample values: 'uid', 'first_name', 'last_name', 'nickname', 'sex', 'bdate' (birthdate), 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'domain', 'has_mobile', 'rate', 'contacts', 'education'.;</param>
        /// <param name="name_case">Case for declension of user name and surname: ; 'nom' — nominative (default) ; 'gen' — genitive ; 'dat' — dative ; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional</param>
        public async Task<ApiItemsResponse<int?>> GetAvailableForCall(IEnumerable<string> fields = null, string name_case = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (name_case != null)
                parameters.Add("name_case", name_case);

            return await _vkontakte.GetAsync<ApiItemsResponse<int?>>("friends.getAvailableForCall", parameters);
        }

        /// <summary>
        /// Returns a list of friends matching the search criteria.
        /// Docs: <see href="https://vk.com/dev/friends.search">friends.search</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="q">Search query string (e.g., 'Vasya Babich').</param>
        /// <param name="fields">Profile fields to return. Sample values: 'nickname', 'screen_name', 'sex', 'bdate' (birthdate), 'city', 'country', 'timezone', 'photo', 'photo_medium', 'photo_big', 'has_mobile', 'rate', 'contacts', 'education', 'online';</param>
        /// <param name="name_case">Case for declension of user name and surname:; 'nom' — nominative (default); 'gen' — genitive ; 'dat' — dative; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional</param>
        /// <param name="offset">Offset needed to return a specific subset of friends.</param>
        /// <param name="count">Number of friends to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Users.UserFull>> Search(int? user_id = null, string q = null, IEnumerable<string> fields = null, string name_case = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
            if (q != null)
                parameters.Add("q", q);
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (name_case != null)
                parameters.Add("name_case", name_case);
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Users.UserFull>>("friends.search", parameters);
        }

    }
}
