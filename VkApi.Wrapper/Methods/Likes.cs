using VkApi.Wrapper.Objects;
using VkApi.Wrapper.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Methods
{
    public class Likes
    {
        private readonly Vkontakte _vkontakte;

        internal Likes(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Adds the specified object to the 'Likes' list of the current user.
        ///</summary>
        public Task<LikesAddResponse> Add(String type = null, int? ownerId = null, int? itemId = null, String accessKey = null)
        {
            var parameters = new Dictionary<string, string>();
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey.ToApiString());
            return _vkontakte.RequestAsync<LikesAddResponse>("likes.add", parameters);
        }

        ///<summary>
        /// Deletes the specified object from the 'Likes' list of the current user.
        ///</summary>
        public Task<LikesDeleteResponse> Delete(String type = null, int? ownerId = null, int? itemId = null, String accessKey = null)
        {
            var parameters = new Dictionary<string, string>();
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey.ToApiString());
            return _vkontakte.RequestAsync<LikesDeleteResponse>("likes.delete", parameters);
        }

        ///<summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        ///</summary>
        public Task<LikesGetListResponse> GetList(String type = null, int? ownerId = null, int? itemId = null, String pageUrl = null, String filter = null, int? friendsOnly = null, Boolean? extended = null, int? offset = null, int? count = null, Boolean? skipOwn = null)
        {
            var parameters = new Dictionary<string, string>();
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (pageUrl != null)
                parameters.Add("page_url", pageUrl.ToApiString());
            if (filter != null)
                parameters.Add("filter", filter.ToApiString());
            if (friendsOnly != null)
                parameters.Add("friends_only", friendsOnly.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (skipOwn != null)
                parameters.Add("skip_own", skipOwn.ToApiString());
            return _vkontakte.RequestAsync<LikesGetListResponse>("likes.getList", parameters);
        }

        ///<summary>
        /// Checks for the object in the 'Likes' list of the specified user.
        ///</summary>
        public Task<LikesIsLikedResponse> IsLiked(int? userId = null, String type = null, int? ownerId = null, int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            return _vkontakte.RequestAsync<LikesIsLikedResponse>("likes.isLiked", parameters);
        }
    }
}