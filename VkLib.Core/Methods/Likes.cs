using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Likes API section.
    /// </summary>
    public class Likes
    {
        private Vkontakte _vkontakte;

        internal Likes(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of IDs of users who added the specified object to their 'Likes' list.
        /// Docs: <see href="https://vk.com/dev/likes.getList">likes.getList</see>
        /// </summary>
        /// <param name="type">; Object type:; 'post' — post on user or community wall; 'comment' — comment on a wall post; 'photo' — photo; 'audio' — audio; 'video' — video; 'note' — note; 'photo_comment' — comment on the photo; 'video_comment' — comment on the video; 'topic_comment' — comment in the discussion; 'sitepage' — page of the site where the [vk.com/dev/Like|Like widget] is installed</param>
        /// <param name="owner_id">ID of the user, community, or application that owns the object. If the 'type' parameter is set as 'sitepage', the application ID is passed as 'owner_id'. Use negative value for a community id. If the 'type' parameter is not set, the 'owner_id' is assumed to be either the current user or the same application ID as if the 'type' parameter was set to 'sitepage'.; ;</param>
        /// <param name="item_id">Object ID. If 'type' is set as 'sitepage', 'item_id' can include the 'page_id' parameter value used during initialization of the [vk.com/dev/Like|Like widget].</param>
        /// <param name="page_url">URL of the page where the [vk.com/dev/Like|Like widget] is installed. Used instead of the 'item_id' parameter.</param>
        /// <param name="filter">Filters to apply:; 'likes' — returns information about all users who liked the object (default); 'copies' — returns information only about users who told their friends about the object</param>
        /// <param name="friends_only">Specifies which users are returned:; '1' — to return only the current user's friends; '0' — to return all users (default)</param>
        /// <param name="extended">Specifies whether extended information will be returned.; '1' — to return extended information about users and communities from the 'Likes' list; '0' — to return no additional information (default)</param>
        /// <param name="offset">Offset needed to select a specific subset of users.</param>
        /// <param name="count">Number of user IDs to return (maximum '1000').; Default is '100' if 'friends_only' is set to '0'; otherwise, the default is '10' if 'friends_only' is set to '1'.;</param>
        /// <param name="skip_own"></param>
        public async Task<object> GetList(string type = null, int? owner_id = null, int? item_id = null, string page_url = null, string filter = null, bool? friends_only = null, bool? extended = null, int? offset = null, int? count = null, bool? skip_own = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (type != null)
                parameters.Add("type", type);
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());
            if (page_url != null)
                parameters.Add("page_url", page_url);
            if (filter != null)
                parameters.Add("filter", filter);
            if (friends_only != null)
                parameters.Add("friends_only", friends_only.ToString());
            if (extended != null)
                parameters.Add("extended", extended.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (skip_own != null)
                parameters.Add("skip_own", skip_own.ToString());

            return await _vkontakte.GetAsync<object>("likes.getList", parameters);
        }

        /// <summary>
        /// Adds the specified object to the 'Likes' list of the current user.
        /// Docs: <see href="https://vk.com/dev/likes.add">likes.add</see>
        /// </summary>
        /// <param name="type">Object type:; 'post' — post on user or community wall; 'comment' — comment on a wall post; 'photo' — photo; 'audio' — audio; 'video' — video; 'note' — note; 'photo_comment' — comment on the photo; 'video_comment' — comment on the video; 'topic_comment' — comment in the discussion; 'sitepage' — page of the site where the [vk.com/dev/Like|Like widget] is installed</param>
        /// <param name="owner_id">ID of the user or community that owns the object.</param>
        /// <param name="item_id">Object ID.</param>
        /// <param name="access_key">Access key required for an object owned by a private entity.;</param>
        public async Task<object> Add(string type = null, int? owner_id = null, int? item_id = null, string access_key = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (type != null)
                parameters.Add("type", type);
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());
            if (access_key != null)
                parameters.Add("access_key", access_key);

            return await _vkontakte.GetAsync<object>("likes.add", parameters);
        }

        /// <summary>
        /// Deletes the specified object from the 'Likes' list of the current user.
        /// Docs: <see href="https://vk.com/dev/likes.delete">likes.delete</see>
        /// </summary>
        /// <param name="type">Object type:; 'post' — post on user or community wall; 'comment' — comment on a wall post; 'photo' — photo; 'audio' — audio; 'video' — video; 'note' — note; 'photo_comment' — comment on the photo; 'video_comment' — comment on the video; 'topic_comment' — comment in the discussion; 'sitepage' — page of the site where the [vk.com/dev/Like|Like widget] is installed</param>
        /// <param name="owner_id">ID of the user or community that owns the object.</param>
        /// <param name="item_id">Object ID.</param>
        public async Task<object> Delete(string type = null, int? owner_id = null, int? item_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (type != null)
                parameters.Add("type", type);
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());

            return await _vkontakte.GetAsync<object>("likes.delete", parameters);
        }

        /// <summary>
        /// Checks for the object in the 'Likes' list of the specified user.
        /// Docs: <see href="https://vk.com/dev/likes.isLiked">likes.isLiked</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="type">Object type:; 'post' — post on user or community wall; 'comment' — comment on a wall post; 'photo' — photo; 'audio' — audio; 'video' — video; 'note' — note; 'photo_comment' — comment on the photo; 'video_comment' — comment on the video; 'topic_comment' — comment in the discussion</param>
        /// <param name="owner_id">ID of the user or community that owns the object.</param>
        /// <param name="item_id">Object ID.</param>
        public async Task<object> IsLiked(int? user_id = null, string type = null, int? owner_id = null, int? item_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (type != null)
                parameters.Add("type", type);
            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());

            return await _vkontakte.GetAsync<object>("likes.isLiked", parameters);
        }

    }
}
