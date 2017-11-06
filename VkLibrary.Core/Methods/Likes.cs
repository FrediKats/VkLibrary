using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Likes;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Likes API section.
    /// </summary>
    public class Likes
    {
        private readonly Vkontakte _vkontakte;
        internal Likes(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// Docs: <see href="https://vk.com/dev/likes.getList">likes.getList</see>
        /// </summary>
        /// <param name="type">
        /// ; Object type:; 'post' — post on user or community wall; 'comment' — comment on a wall post; 'photo'
        /// — photo; 'audio' — audio; 'video' — video; 'note' — note; 'photo_comment' — comment on the photo; 'video_comment' —
        /// comment on the video; 'topic_comment' — comment in the discussion; 'sitepage' — page of the site where the
        /// Like widget is installed
        /// </param>
        /// <param name="ownerId">
        /// ID of the user, community, or application that owns the object. If the 'type' parameter is set
        /// as 'sitepage', the application ID is passed as 'owner_id'. Use negative value for a community id. If the 'type'
        /// parameter is not set, the 'owner_id' is assumed to be either the current user or the same application ID as if the
        /// 'type' parameter was set to 'sitepage'.; ;
        /// </param>
        /// <param name="itemId">
        /// Object ID. If 'type' is set as 'sitepage', 'item_id' can include the 'page_id' parameter value
        /// used during initialization of the Like widget.
        /// </param>
        /// <param name="pageUrl">
        /// URL of the page where the Like widget is installed. Used instead of the
        /// 'item_id' parameter.
        /// </param>
        /// <param name="filter">
        /// Filters to apply:; 'likes' — returns information about all users who liked the object (default);
        /// 'copies' — returns information only about users who told their friends about the object
        /// </param>
        /// <param name="friendsOnly">
        /// Specifies which users are returned:; '1' — to return only the current user's friends; '0' —
        /// to return all users (default)
        /// </param>
        /// <param name="offset">Offset needed to select a specific subset of users.</param>
        /// <param name="count">
        /// Number of user IDs to return (maximum '1000').; Default is '100' if 'friends_only' is set to '0';
        /// otherwise, the default is '10' if 'friends_only' is set to '1'.;
        /// </param>
        /// <param name="skipOwn"></param>
        public Task<ApiItemsResponse<int?>> GetList(string type = null, int? ownerId = null, 
            int? itemId = null, string pageUrl = null, string filter = null, bool? friendsOnly = null, 
            int? offset = null, int? count = null, bool? skipOwn = null)
        {
            var parameters = new Dictionary<string, string>();

            if (type != null)
                parameters.Add("type", type);
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (pageUrl != null)
                parameters.Add("page_url", pageUrl);
            if (filter != null)
                parameters.Add("filter", filter);
            if (friendsOnly != null)
                parameters.Add("friends_only", friendsOnly.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (skipOwn != null)
                parameters.Add("skip_own", skipOwn.ToApiString());

            parameters.Add("extended", false.ToApiString());
            return _vkontakte.RequestAsync<ApiItemsResponse<int?>>("likes.getList", parameters);
        }

        /// <summary>
        /// Adds the specified object to the 'Likes' list of the current user.
        /// Docs: <see href="https://vk.com/dev/likes.add">likes.add</see>
        /// </summary>
        /// <param name="type">
        /// Object type:; 'post' — post on user or community wall; 'comment' — comment on a wall post; 'photo' —
        /// photo; 'audio' — audio; 'video' — video; 'note' — note; 'photo_comment' — comment on the photo; 'video_comment' —
        /// comment on the video; 'topic_comment' — comment in the discussion; 'sitepage' — page of the site where the
        /// Like widget is installed
        /// </param>
        /// <param name="ownerId">ID of the user or community that owns the object.</param>
        /// <param name="itemId">Object ID.</param>
        /// <param name="accessKey">Access key required for an object owned by a private entity.;</param>
        public Task<AddResponse> Add(string type = null, int? ownerId = null, int? itemId = null,
            string accessKey = null)
        {
            var parameters = new Dictionary<string, string>();

            if (type != null)
                parameters.Add("type", type);
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());
            if (accessKey != null)
                parameters.Add("access_key", accessKey);

            return _vkontakte.RequestAsync<AddResponse>("likes.add", parameters);
        }

        /// <summary>
        /// Deletes the specified object from the 'Likes' list of the current user.
        /// Docs: <see href="https://vk.com/dev/likes.delete">likes.delete</see>
        /// </summary>
        /// <param name="type">
        /// Object type:; 'post' — post on user or community wall; 'comment' — comment on a wall post; 'photo' —
        /// photo; 'audio' — audio; 'video' — video; 'note' — note; 'photo_comment' — comment on the photo; 'video_comment' —
        /// comment on the video; 'topic_comment' — comment in the discussion; 'sitepage' — page of the site where the
        /// Like widget is installed
        /// </param>
        /// <param name="ownerId">ID of the user or community that owns the object.</param>
        /// <param name="itemId">Object ID.</param>
        public Task<DeleteResponse> Delete(string type = null, int? ownerId = null, int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (type != null)
                parameters.Add("type", type);
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());

            return _vkontakte.RequestAsync<DeleteResponse>("likes.delete", parameters);
        }

        /// <summary>
        /// Checks for the object in the 'Likes' list of the specified user.
        /// Docs: <see href="https://vk.com/dev/likes.isLiked">likes.isLiked</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="type">
        /// Object type:; 'post' — post on user or community wall; 'comment' — comment on a wall post; 'photo' —
        /// photo; 'audio' — audio; 'video' — video; 'note' — note; 'photo_comment' — comment on the photo; 'video_comment' —
        /// comment on the video; 'topic_comment' — comment in the discussion
        /// </param>
        /// <param name="ownerId">ID of the user or community that owns the object.</param>
        /// <param name="itemId">Object ID.</param>
        public Task<IsLikedResponse> IsLiked(int? userId = null, string type = null, int? ownerId = null,
            int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (type != null)
                parameters.Add("type", type);
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());

            return _vkontakte.RequestAsync<IsLikedResponse>("likes.isLiked", parameters);
        }
    }
}