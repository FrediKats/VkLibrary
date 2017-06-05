using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Newsfeed;
using VkLibrary.Core.Types.Newsfeed;
using VkLibrary.Core.Types.Wall;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Newsfeed API section.
    /// </summary>
    public class Newsfeed
    {
        private readonly Vkontakte _vkontakte;

        internal Newsfeed(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns data required to show newsfeed for the current user.
        /// Docs: <see href="https://vk.com/dev/newsfeed.get">newsfeed.get</see>
        /// </summary>
        /// <param name="filters">
        /// Filters to apply:; 'post' — new wall posts; 'photo' — new photos; 'photo_tag' — new photo tags;
        /// 'wall_photo' — new wall photos; 'friend' — new friends; 'note' — new notes
        /// </param>
        /// <param name="returnBanned">'1' — to return news items from banned sources</param>
        /// <param name="startTime">Earliest timestamp (in Unix time) of a news item to return. By default, 24 hours ago.</param>
        /// <param name="endTime">Latest timestamp (in Unix time) of a news item to return. By default, the current time.</param>
        /// <param name="maxPhotos">Maximum number of photos to return. By default, '5'.</param>
        /// <param name="sourceIds">
        /// Sources to obtain news from, separated by commas.; ; User IDs can be specified in formats ''
        /// or 'u' ; where '' is the user's friend ID.; ; Community IDs can be specified in formats '-' or 'g' ; where '' is
        /// the community ID.; ; If the parameter is not set, all of the user's friends and communities are returned, except
        /// for banned sources, which can be obtained with the [vk.com/dev/newsfeed.getBanned|newsfeed.getBanned] method.;
        /// </param>
        /// <param name="startFrom">
        /// identifier required to get the next page of results. ; Value for this parameter is returned in
        /// 'next_from' field in a reply.
        /// </param>
        /// <param name="count">
        /// Number of news items to return (default 50; maximum 100). For auto feed, you can use the
        /// 'new_offset' parameter returned by this method.
        /// </param>
        /// <param name="fields">
        /// Additional fields of [vk.com/dev/fields|profiles] and [vk.com/dev/fields_groups|communities] to
        /// return.
        /// </param>
        public Task<NewsFeedResponse> Get(IEnumerable<string> filters = null, bool? returnBanned = null,
            int? startTime = null, int? endTime = null, int? maxPhotos = null, string sourceIds = null,
            string startFrom = null, int? count = null, IEnumerable<string> fields = null)
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
                parameters.Add("source_ids", sourceIds);
            if (startFrom != null)
                parameters.Add("start_from", startFrom);
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return _vkontakte.GetAsync<NewsFeedResponse>("newsfeed.get", parameters);
        }

        /// <summary>
        /// ; Returns a list of newsfeeds recommended to the current user.
        /// Docs: <see href="https://vk.com/dev/newsfeed.getRecommended">newsfeed.getRecommended</see>
        /// </summary>
        /// <param name="startTime">Earliest timestamp (in Unix time) of a news item to return. By default, 24 hours ago.</param>
        /// <param name="endTime">Latest timestamp (in Unix time) of a news item to return. By default, the current time.</param>
        /// <param name="maxPhotos">Maximum number of photos to return. By default, '5'.</param>
        /// <param name="startFrom">'new_from' value obtained in previous call.</param>
        /// <param name="count">Number of news items to return.</param>
        /// <param name="fields">
        /// Additional fields of [vk.com/dev/fields|profiles] and [vk.com/dev/fields_groups|communities] to
        /// return.
        /// </param>
        public Task<NewsFeedResponse> GetRecommended(int? startTime = null, int? endTime = null,
            int? maxPhotos = null, string startFrom = null, int? count = null, IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (startTime != null)
                parameters.Add("start_time", startTime.ToApiString());
            if (endTime != null)
                parameters.Add("end_time", endTime.ToApiString());
            if (maxPhotos != null)
                parameters.Add("max_photos", maxPhotos.ToApiString());
            if (startFrom != null)
                parameters.Add("start_from", startFrom);
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return _vkontakte.GetAsync<NewsFeedResponse>("newsfeed.getRecommended", parameters);
        }

        /// <summary>
        /// Returns a list of comments in the current user's newsfeed.
        /// Docs: <see href="https://vk.com/dev/newsfeed.getComments">newsfeed.getComments</see>
        /// </summary>
        /// <param name="count">
        /// Number of comments to return. For auto feed, you can use the 'new_offset' parameter returned by
        /// this method.
        /// </param>
        /// <param name="filters">
        /// Filters to apply:; 'post' — new comments on wall posts; 'photo' — new comments on photos; 'video'
        /// — new comments on videos; 'topic' — new comments on discussions; 'note' — new comments on notes;
        /// </param>
        /// <param name="reposts">
        /// Object ID, comments on repost of which shall be returned, e.g. 'wall1_45486'. (If the parameter
        /// is set, the 'filters' parameter is optional.);
        /// </param>
        /// <param name="startTime">Earliest timestamp (in Unix time) of a comment to return. By default, 24 hours ago.</param>
        /// <param name="endTime">Latest timestamp (in Unix time) of a comment to return. By default, the current time.</param>
        /// <param name="startFrom">
        /// Identificator needed to return the next page with results. Value for this parameter returns in
        /// 'next_from' field.
        /// </param>
        /// <param name="fields">
        /// Additional fields of [vk.com/dev/fields|profiles] and [vk.com/dev/fields_groups|communities] to
        /// return.
        /// </param>
        public Task<NewsFeedResponse> GetComments(int? count = null, IEnumerable<string> filters = null,
            string reposts = null, int? startTime = null, int? endTime = null, string startFrom = null,
            IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (filters != null)
                parameters.Add("filters", filters.ToApiString());
            if (reposts != null)
                parameters.Add("reposts", reposts);
            if (startTime != null)
                parameters.Add("start_time", startTime.ToApiString());
            if (endTime != null)
                parameters.Add("end_time", endTime.ToApiString());
            if (startFrom != null)
                parameters.Add("start_from", startFrom);
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return _vkontakte.GetAsync<NewsFeedResponse>("newsfeed.getComments", parameters);
        }

        /// <summary>
        /// Returns a list of posts on user walls in which the current user is mentioned.;
        /// Docs: <see href="https://vk.com/dev/newsfeed.getMentions">newsfeed.getMentions</see>
        /// </summary>
        /// <param name="ownerId">Owner ID.</param>
        /// <param name="startTime">Earliest timestamp (in Unix time) of a post to return. By default, 24 hours ago.;</param>
        /// <param name="endTime">Latest timestamp (in Unix time) of a post to return. By default, the current time.;</param>
        /// <param name="offset">Offset needed to return a specific subset of posts.</param>
        /// <param name="count">Number of posts to return.</param>
        public Task<ApiItemsResponse<WallpostToId>> GetMentions(int? ownerId = null, int? startTime = null,
            int? endTime = null, int? offset = null, int? count = null)
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

            return _vkontakte.GetAsync<ApiItemsResponse<WallpostToId>>("newsfeed.getMentions", parameters);
        }

        /// <summary>
        /// Returns a list of users and communities banned from the current user's newsfeed.
        /// Docs: <see href="https://vk.com/dev/newsfeed.getBanned">newsfeed.getBanned</see>
        /// </summary>
        /// <param name="extended">'1' — return extra information about users and communities</param>
        /// <param name="fields">Profile fields to return.; ;</param>
        /// <param name="nameCase">
        /// Case for declension of user name and surname:; 'nom' — nominative (default); 'gen' — genitive ;
        /// 'dat' — dative; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional
        /// </param>
        public Task<GetBannedResponse> GetBanned(bool? extended = null, IEnumerable<string> fields = null,
            string nameCase = null)
        {
            var parameters = new Dictionary<string, string>();

            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase);

            return _vkontakte.GetAsync<GetBannedResponse>("newsfeed.getBanned", parameters);
        }

        /// <summary>
        /// Prevents news from specified users and communities from appearing in the current user's newsfeed.
        /// Docs: <see href="https://vk.com/dev/newsfeed.addBan">newsfeed.addBan</see>
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="groupIds"></param>
        public Task<int> AddBan(IEnumerable<int?> userIds = null, IEnumerable<int?> groupIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (groupIds != null)
                parameters.Add("group_ids", groupIds.ToApiString());

            return _vkontakte.GetAsync<int>("newsfeed.addBan", parameters);
        }

        /// <summary>
        /// Allows news from previously banned users and communities to be shown in the current user's newsfeed.
        /// Docs: <see href="https://vk.com/dev/newsfeed.deleteBan">newsfeed.deleteBan</see>
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="groupIds"></param>
        public Task<int> DeleteBan(IEnumerable<int?> userIds = null, IEnumerable<int?> groupIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (groupIds != null)
                parameters.Add("group_ids", groupIds.ToApiString());

            return _vkontakte.GetAsync<int>("newsfeed.deleteBan", parameters);
        }

        /// <summary>
        /// Hides an item from the newsfeed.
        /// Docs: <see href="https://vk.com/dev/newsfeed.ignoreItem">newsfeed.ignoreItem</see>
        /// </summary>
        /// <param name="type">
        /// Item type. Possible values:; *'wall' – post on the wall;; *'tag' – tag on a photo;; *'profilephoto'
        /// – profile photo;; *'video' – video;; *'audio' – audio.
        /// </param>
        /// <param name="ownerId">
        /// Item owner's identifier (user or community); "Note that community id must be negative. ;
        /// 'owner_id=1' – user ; 'owner_id=-1' – community "
        /// </param>
        /// <param name="itemId">Item identifier</param>
        public Task<int> IgnoreItem(string type = null, int? ownerId = null, int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (type != null)
                parameters.Add("type", type);
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());

            return _vkontakte.GetAsync<int>("newsfeed.ignoreItem", parameters);
        }

        /// <summary>
        /// Returns a hidden item to the newsfeed.
        /// Docs: <see href="https://vk.com/dev/newsfeed.unignoreItem">newsfeed.unignoreItem</see>
        /// </summary>
        /// <param name="type">
        /// Item type. Possible values:; *'wall' – post on the wall;; *'tag' – tag on a photo;; *'profilephoto'
        /// – profile photo;; *'video' – video;; *'audio' – audio.
        /// </param>
        /// <param name="ownerId">
        /// Item owner's identifier (user or community); "Note that community id must be negative. ;
        /// 'owner_id=1' – user ; 'owner_id=-1' – community "
        /// </param>
        /// <param name="itemId">Item identifier</param>
        public Task<int> UnignoreItem(string type = null, int? ownerId = null, int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (type != null)
                parameters.Add("type", type);
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());

            return _vkontakte.GetAsync<int>("newsfeed.unignoreItem", parameters);
        }

        /// <summary>
        /// Returns search results by statuses.;
        /// Docs: <see href="https://vk.com/dev/newsfeed.search">newsfeed.search</see>
        /// </summary>
        /// <param name="q">Search query string (e.g., 'New Year').</param>
        /// <param name="extended">'1' — to return additional information about the user or community that placed the post.</param>
        /// <param name="count">Number of posts to return.</param>
        /// <param name="latitude">Geographical latitude point (in degrees, -90 to 90) within which to search.;</param>
        /// <param name="longitude">Geographical longitude point (in degrees, -180 to 180) within which to search.;</param>
        /// <param name="startTime">Earliest timestamp (in Unix time) of a news item to return. By default, 24 hours ago.</param>
        /// <param name="endTime">Latest timestamp (in Unix time) of a news item to return. By default, the current time.</param>
        /// <param name="startFrom"></param>
        /// <param name="fields">
        /// Additional fields of [vk.com/dev/fields|profiles] and [vk.com/dev/fields_groups|communities] to
        /// return.
        /// </param>
        public Task<ApiItemsResponse<WallpostFull>> Search(string q = null, bool? extended = null,
            int? count = null, uint? latitude = null, uint? longitude = null, int? startTime = null,
            int? endTime = null, string startFrom = null, IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
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
                parameters.Add("start_from", startFrom);
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<WallpostFull>>("newsfeed.search", parameters);
        }

        /// <summary>
        /// Returns a list of newsfeeds followed by the current user.
        /// Docs: <see href="https://vk.com/dev/newsfeed.getLists">newsfeed.getLists</see>
        /// </summary>
        /// <param name="listIds">numeric list identifiers.</param>
        public Task<ApiItemsResponse<List>> GetLists(IEnumerable<int?> listIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (listIds != null)
                parameters.Add("list_ids", listIds.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<List>>("newsfeed.getLists", parameters);
        }

        /// <summary>
        /// Creates and edits user newsfeed lists
        /// Docs: <see href="https://vk.com/dev/newsfeed.saveList">newsfeed.saveList</see>
        /// </summary>
        /// <param name="listId">numeric list identifier (if not sent, will be set automatically).</param>
        /// <param name="title">list name.</param>
        /// <param name="sourceIds">
        /// users and communities identifiers to be added to the list. Community identifiers must be
        /// negative numbers.
        /// </param>
        /// <param name="noReposts">reposts display on and off ('1' is for off).</param>
        public Task<int?> SaveList(int? listId = null, string title = null, IEnumerable<int?> sourceIds = null,
            bool? noReposts = null)
        {
            var parameters = new Dictionary<string, string>();

            if (listId != null)
                parameters.Add("list_id", listId.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (sourceIds != null)
                parameters.Add("source_ids", sourceIds.ToApiString());
            if (noReposts != null)
                parameters.Add("no_reposts", noReposts.ToApiString());

            return _vkontakte.GetAsync<int?>("newsfeed.saveList", parameters);
        }

        /// <summary>
        /// Docs: <see href="https://vk.com/dev/newsfeed.deleteList">newsfeed.deleteList</see>
        /// </summary>
        /// <param name="listId"></param>
        public Task<int> DeleteList(int? listId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (listId != null)
                parameters.Add("list_id", listId.ToApiString());

            return _vkontakte.GetAsync<int>("newsfeed.deleteList", parameters);
        }

        /// <summary>
        /// Unsubscribes the current user from specified newsfeeds.
        /// Docs: <see href="https://vk.com/dev/newsfeed.unsubscribe">newsfeed.unsubscribe</see>
        /// </summary>
        /// <param name="type">
        /// Type of object from which to unsubscribe:; 'note' — note; 'photo' — photo; 'post' — post on user
        /// wall or community wall; 'topic' — topic; 'video' — video
        /// </param>
        /// <param name="ownerId">Object owner ID.</param>
        /// <param name="itemId">Object ID.</param>
        public Task<int> Unsubscribe(string type = null, int? ownerId = null, int? itemId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (type != null)
                parameters.Add("type", type);
            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (itemId != null)
                parameters.Add("item_id", itemId.ToApiString());

            return _vkontakte.GetAsync<int>("newsfeed.unsubscribe", parameters);
        }

        /// <summary>
        /// Returns communities and users that current user is suggested to follow.
        /// Docs: <see href="https://vk.com/dev/newsfeed.getSuggestedSources">newsfeed.getSuggestedSources</see>
        /// </summary>
        /// <param name="offset">offset required to choose a particular subset of communities or users.</param>
        /// <param name="count">amount of communities or users to return.</param>
        /// <param name="shuffle">shuffle the returned list or not.</param>
        /// <param name="fields">
        /// list of extra fields to be returned. See available fields for [vk.com/dev/fields|users] and
        /// [vk.com/dev/fields_groups|communities].
        /// </param>
        public Task<ApiItemsResponse<object>> GetSuggestedSources(int? offset = null, int? count = null,
            bool? shuffle = null, IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (shuffle != null)
                parameters.Add("shuffle", shuffle.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<object>>("newsfeed.getSuggestedSources", parameters);
        }
    }
}