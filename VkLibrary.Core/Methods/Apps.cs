using VkLibrary.Core.Objects;
using VkLibrary.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Methods
{
    public class Apps
    {
        private readonly Vkontakte _vkontakte;

        internal Apps(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Deletes all request notifications from the current app.
        ///</summary>
        public Task<BaseOkResponse> DeleteAppRequests()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<BaseOkResponse>("apps.deleteAppRequests", parameters);
        }

        ///<summary>
        /// Returns applications data.
        ///</summary>
        public Task<AppsGetResponse> Get(int? appId = null, String[] appIds = null, String platform = null, Boolean? extended = null, Boolean? returnFriends = null, UsersFields[] fields = null, String nameCase = null)
        {
            var parameters = new Dictionary<string, string>();
            if (appId != null)
                parameters.Add("app_id", appId.ToApiString());
            if (appIds != null)
                parameters.Add("app_ids", appIds.ToApiString());
            if (platform != null)
                parameters.Add("platform", platform.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (returnFriends != null)
                parameters.Add("return_friends", returnFriends.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase.ToApiString());
            return _vkontakte.RequestAsync<AppsGetResponse>("apps.get", parameters);
        }

        ///<summary>
        /// Returns a list of applications (apps) available to users in the App Catalog.
        ///</summary>
        public Task<AppsGetCatalogResponse> GetCatalog(String sort = null, int? offset = null, int? count = null, String platform = null, Boolean? extended = null, Boolean? returnFriends = null, UsersFields[] fields = null, String nameCase = null, String q = null, int? genreId = null, String filter = null)
        {
            var parameters = new Dictionary<string, string>();
            if (sort != null)
                parameters.Add("sort", sort.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (platform != null)
                parameters.Add("platform", platform.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (returnFriends != null)
                parameters.Add("return_friends", returnFriends.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase.ToApiString());
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (genreId != null)
                parameters.Add("genre_id", genreId.ToApiString());
            if (filter != null)
                parameters.Add("filter", filter.ToApiString());
            return _vkontakte.RequestAsync<AppsGetCatalogResponse>("apps.getCatalog", parameters);
        }

        ///<summary>
        /// Creates friends list for requests and invites in current app.
        ///</summary>
        public Task<AppsGetFriendsListResponse> GetFriendsList(Boolean? extended = null, int? count = null, int? offset = null, String type = null, UsersFields[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<AppsGetFriendsListResponse>("apps.getFriendsList", parameters);
        }

        ///<summary>
        /// Returns players rating in the game.
        ///</summary>
        public Task<AppsGetLeaderboardResponse> GetLeaderboard(String type = null, Boolean? global = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (global != null)
                parameters.Add("global", global.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<AppsGetLeaderboardResponse>("apps.getLeaderboard", parameters);
        }

        ///<summary>
        /// Returns scopes for auth
        ///</summary>
        public Task<AppsGetScopesResponse> GetScopes(String type = null)
        {
            var parameters = new Dictionary<string, string>();
            if (type != null)
                parameters.Add("type", type.ToApiString());
            return _vkontakte.RequestAsync<AppsGetScopesResponse>("apps.getScopes", parameters);
        }

        ///<summary>
        /// Returns user score in app
        ///</summary>
        public Task<int> GetScore(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            return _vkontakte.RequestAsync<int>("apps.getScore", parameters);
        }

        ///<summary>
        /// Sends a request to another user in an app that uses VK authorization.
        ///</summary>
        public Task<int> SendRequest(int? userId = null, String text = null, String type = null, String name = null, String key = null, Boolean? separate = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (text != null)
                parameters.Add("text", text.ToApiString());
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (name != null)
                parameters.Add("name", name.ToApiString());
            if (key != null)
                parameters.Add("key", key.ToApiString());
            if (separate != null)
                parameters.Add("separate", separate.ToApiString());
            return _vkontakte.RequestAsync<int>("apps.sendRequest", parameters);
        }
    }
}