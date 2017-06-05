using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Newsfeed;
using VkLibrary.Core.Responses.Wall;
using VkLibrary.Core.Types.Wall;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Wall API section.
    /// </summary>
    public class Wall
    {
        private readonly Vkontakte _vkontakte;

        internal Wall(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns a list of posts on a user wall or community wall.
        /// </summary>
        /// <param name="ownerId">
        /// ID of the user or community that owns the wall. By default, current user ID. Use a negative
        /// value to designate a community ID.
        /// </param>
        /// <param name="domain">User or community short address.</param>
        /// <param name="offset">Offset needed to return a specific subset of posts.</param>
        /// <param name="count">Number of posts to return (maximum 100).</param>
        /// <param name="filter">
        /// Filter to apply: 'owner' — posts by the wall owner; 'others' — posts by someone else; 'all' —
        /// posts by the wall owner and others (default); 'postponed' — timed posts (only available for calls with an
        /// 'access_token'); 'suggests' — suggested posts on a community wall
        /// </param>
        /// <param name="extended">
        /// '1' — to return 'wall', 'profiles', and 'groups' fields; '0' — to return no additional fields
        /// (default)
        /// </param>
        /// <param name="fields"></param>
        public Task<NewsFeedResponse> Get(
            int? ownerId = null, string domain = null, int? offset = null, int? count = null,
            string filter = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (domain != null)
                parameters.Add("domain", domain);
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (filter != null)
                parameters.Add("filter", filter.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return _vkontakte.GetAsync<NewsFeedResponse>("wall.get", parameters);
        }

        /// <summary>
        /// Allows to search posts on user or community walls.
        /// </summary>
        /// <param name="ownerId">user or community id. Remember that for a community 'owner_id' must be negative.</param>
        /// <param name="domain">user or community screen name.</param>
        /// <param name="query">search query string.</param>
        /// <param name="ownersOnly">'1' – returns only page owner's posts.</param>
        /// <param name="count">count of posts to return.</param>
        /// <param name="extended">count of posts to return.</param>
        /// <param name="fields"></param>
        public Task<ApiItemsResponse<WallpostFull>> Search(
            int? ownerId = null, string domain = null, string query = null, bool? ownersOnly = null,
            int? count = null, bool? extended = null, IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (domain != null)
                parameters.Add("domain", domain.ToApiString());
            if (query != null)
                parameters.Add("query", query);
            if (ownersOnly != null)
                parameters.Add("owners_only", ownersOnly.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<WallpostFull>>("wall.get", parameters);
        }

        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// Docs: <see href="https://vk.com/dev/wall.getById">wall.getById</see>
        /// </summary>
        /// <param name="posts">
        /// User or community IDs and post IDs, separated by underscores. Use a negative value to designate a
        /// community ID. Example:; "93388_21539,93388_20904,2943_4276,-1_1"
        /// </param>
        /// <param name="extended">
        /// '1' — to return user and community objects needed to display posts; '0' — no additional fields
        /// are returned (default)
        /// </param>
        /// <param name="copyHistoryDepth">
        /// Sets the number of parent elements to include in the array 'copy_history' that is
        /// returned if the post is a repost from another wall.
        /// </param>
        /// <param name="fields"></param>
        public Task<NewsFeedResponse> GetById(IEnumerable<string> posts = null, bool? extended = null,
            int? copyHistoryDepth = null, IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (posts != null)
                parameters.Add("posts", posts.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (copyHistoryDepth != null)
                parameters.Add("copy_history_depth", copyHistoryDepth.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return _vkontakte.GetAsync<NewsFeedResponse>("wall.getById", parameters);
        }

        /// <summary>
        /// Adds a new post on a user wall or community wall. Can also be used to publish suggested or scheduled posts.
        /// Docs: <see href="https://vk.com/dev/wall.post">wall.post</see>
        /// </summary>
        /// <param name="ownerId">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="friendsOnly">
        /// '1' — post will be available to friends only; '0' — post will be available to all users
        /// (default)
        /// </param>
        /// <param name="fromGroup">
        /// For a community:; '1' — post will be published by the community; '0' — post will be published
        /// by the user (default)
        /// </param>
        /// <param name="message">(Required if 'attachments' is not set.) Text of the post.</param>
        /// <param name="attachments">
        /// (Required if 'message' is not set.) List of objects attached to the post, in the following format:; 
        /// "%owner_id%_%media_id%, %owner_id%_%media_id%"; 
        /// '' — Type of media attachment:; 
        /// 'photo' — photo; 
        /// 'video' — video; 
        /// 'audio' — audio; 
        /// 'doc' — document; 
        /// '%owner_id%' — Media attachment owner ID.; 
        /// '%media_id%' — Media attachment ID.;
        /// Example:; "photo100172_166443618,photo66748_265827614"
        /// </param>
        /// <param name="services">
        /// List of services or websites the update will be exported to, if the user has so requested.
        /// Sample values: 'twitter', 'facebook'.
        /// </param>
        /// <param name="signed">
        /// Only for posts in communities with 'from_group' set to '1':; '1' — post will be signed with the
        /// name of the posting user; '0' — post will not be signed (default)
        /// </param>
        /// <param name="publishDate">Publication date (in Unix time). If used, posting will be delayed until the set time.</param>
        /// <param name="lat">Geographical latitude of a check-in, in degrees (from -90 to 90).</param>
        /// <param name="long_">Geographical longitude of a check-in, in degrees (from -180 to 180).</param>
        /// <param name="placeId">ID of the location where the user was tagged.</param>
        /// <param name="postId">Post ID. Used for publishing of scheduled and suggested posts.</param>
        /// <param name="guid"></param>
        /// <param name="markAsAds"></param>
        public Task<PostResponse> Post(int? ownerId = null, bool? friendsOnly = null, bool? fromGroup = null,
            string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null,
            int? publishDate = null, uint? lat = null, uint? long_ = null, int? placeId = null, int? postId = null,
            string guid = null, bool? markAsAds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (friendsOnly != null)
                parameters.Add("friends_only", friendsOnly.ToApiString());
            if (fromGroup != null)
                parameters.Add("from_group", fromGroup.ToApiString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (services != null)
                parameters.Add("services", services);
            if (signed != null)
                parameters.Add("signed", signed.ToApiString());
            if (publishDate != null)
                parameters.Add("publish_date", publishDate.ToApiString());
            if (lat != null)
                parameters.Add("lat", lat.ToApiString());
            if (long_ != null)
                parameters.Add("long_", long_.ToApiString());
            if (placeId != null)
                parameters.Add("place_id", placeId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (guid != null)
                parameters.Add("guid", guid);
            if (markAsAds != null)
                parameters.Add("mark_as_ads", markAsAds.ToApiString());

            return _vkontakte.GetAsync<PostResponse>("wall.post", parameters);
        }

        /// <summary>
        /// Reposts (copies) an object to a user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.repost">wall.repost</see>
        /// </summary>
        /// <param name="object_">ID of the object to be reposted on the wall. Example:; "wall66748_3675"</param>
        /// <param name="message">Comment to be added along with the reposted object.</param>
        /// <param name="groupId">Target community ID when reposting to a community.</param>
        /// <param name="markAsAds"></param>
        public Task<RepostResponse> Repost(string object_ = null, string message = null, int? groupId = null,
            bool? markAsAds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (object_ != null)
                parameters.Add("object_", object_);
            if (message != null)
                parameters.Add("message", message);
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (markAsAds != null)
                parameters.Add("mark_as_ads", markAsAds.ToApiString());

            return _vkontakte.GetAsync<RepostResponse>("wall.repost", parameters);
        }

        /// <summary>
        /// Returns information about reposts of a post on user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.getReposts">wall.getReposts</see>
        /// </summary>
        /// <param name="ownerId">
        /// User ID or community ID. By default, current user ID. Use a negative value to designate a
        /// community ID.
        /// </param>
        /// <param name="postId">Post ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of reposts.</param>
        /// <param name="count">Number of reposts to return.</param>
        public Task<ApiItemsResponse<WallpostFull>> GetReposts(int? ownerId = null, int? postId = null,
            int? offset = null, int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<WallpostFull>>("wall.getReposts", parameters);
        }

        /// <summary>
        /// Edits a post on a user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.edit">wall.edit</see>
        /// </summary>
        /// <param name="ownerId">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="postId">Post ID.</param>
        /// <param name="friendsOnly">
        /// (Applies only when editing a scheduled post.); '1' — post will be available to friends only;
        /// '0' — post will be available to all users (default)
        /// </param>
        /// <param name="message">(Required if 'attachments' is not set.) Text of the post.</param>
        /// <param name="attachments">
        /// (Required if 'message' is not set.) List of objects attached to the post, in the following format:; 
        /// "%owner_id%_%media_id%, %owner_id%_%media_id%"; 
        /// '' — Type of media attachment:; 
        /// 'photo' — photo; 
        /// 'video' — video; 
        /// 'audio' — audio; 
        /// 'doc' — document; 
        /// '%owner_id%' — Media attachment owner ID.; 
        /// '%media_id%' — Media attachment ID.;
        /// Example:; "photo100172_166443618,photo66748_265827614,http://habrahabr.ru"
        /// </param>
        /// <param name="services">
        /// (Applies only to a scheduled post.) List of services or websites where status will be updated,
        /// if the user has so requested. Sample values: 'twitter', 'facebook'.
        /// </param>
        /// <param name="signed">
        /// (Applies only to a post that was created "as community" on a community wall.); '1' — to add the
        /// signature of the user who created the post
        /// </param>
        /// <param name="publishDate">
        /// (Applies only to a scheduled post.) Publication date (in Unix time). If used, posting will
        /// be delayed until the set time.
        /// </param>
        /// <param name="lat">Geographical latitude of the check-in, in degrees (from -90 to 90).</param>
        /// <param name="long_">Geographical longitude of the check-in, in degrees (from -180 to 180).</param>
        /// <param name="placeId">ID of the location where the user was tagged.</param>
        /// <param name="markAsAds"></param>
        public Task<int> Edit(int? ownerId = null, int? postId = null, bool? friendsOnly = null,
            string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null,
            int? publishDate = null, uint? lat = null, uint? long_ = null, int? placeId = null,
            bool? markAsAds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (friendsOnly != null)
                parameters.Add("friends_only", friendsOnly.ToApiString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (services != null)
                parameters.Add("services", services);
            if (signed != null)
                parameters.Add("signed", signed.ToApiString());
            if (publishDate != null)
                parameters.Add("publish_date", publishDate.ToApiString());
            if (lat != null)
                parameters.Add("lat", lat.ToApiString());
            if (long_ != null)
                parameters.Add("long_", long_.ToApiString());
            if (placeId != null)
                parameters.Add("place_id", placeId.ToApiString());
            if (markAsAds != null)
                parameters.Add("mark_as_ads", markAsAds.ToApiString());

            return _vkontakte.GetAsync<int>("wall.edit", parameters);
        }

        /// <summary>
        /// Deletes a post from a user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.delete">wall.delete</see>
        /// </summary>
        /// <param name="ownerId">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="postId">ID of the post to be deleted.</param>
        public Task<int> Delete(int? ownerId = null, int? postId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());

            return _vkontakte.GetAsync<int>("wall.delete", parameters);
        }

        /// <summary>
        /// Restores a post deleted from a user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.restore">wall.restore</see>
        /// </summary>
        /// <param name="ownerId">
        /// User ID or community ID from whose wall the post was deleted. Use a negative value to designate
        /// a community ID.
        /// </param>
        /// <param name="postId">ID of the post to be restored.</param>
        public Task<int> Restore(int? ownerId = null, int? postId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());

            return _vkontakte.GetAsync<int>("wall.restore", parameters);
        }

        /// <summary>
        /// Pins the post on wall.
        /// Docs: <see href="https://vk.com/dev/wall.pin">wall.pin</see>
        /// </summary>
        /// <param name="ownerId">
        /// ID of the user or community that owns the wall. By default, current user ID. Use a negative
        /// value to designate a community ID.
        /// </param>
        /// <param name="postId">Post ID.</param>
        public Task<int> Pin(int? ownerId = null, int? postId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());

            return _vkontakte.GetAsync<int>("wall.pin", parameters);
        }

        /// <summary>
        /// Unpins the post on wall.
        /// Docs: <see href="https://vk.com/dev/wall.unpin">wall.unpin</see>
        /// </summary>
        /// <param name="ownerId">
        /// ID of the user or community that owns the wall. By default, current user ID. Use a negative
        /// value to designate a community ID.
        /// </param>
        /// <param name="postId">Post ID.</param>
        public Task<int> Unpin(int? ownerId = null, int? postId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());

            return _vkontakte.GetAsync<int>("wall.unpin", parameters);
        }

        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.getComments">wall.getComments</see>
        /// </summary>
        /// <param name="ownerId">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="postId">Post ID.</param>
        /// <param name="needLikes">'1' — to return the 'likes' field; '0' — not to return the 'likes' field (default)</param>
        /// <param name="startCommentId"></param>
        /// <param name="offset">Offset needed to return a specific subset of comments.</param>
        /// <param name="count">Number of comments to return (maximum 100).</param>
        /// <param name="sort">Sort order:; 'asc' — chronological; 'desc' — reverse chronological</param>
        /// <param name="previewLength">
        /// Number of characters at which to truncate comments when previewed. By default, '90'.
        /// Specify '0' if you do not want to truncate comments.;
        /// </param>
        /// <param name="extended"></param>
        public Task<CommentsResponse> GetComments(int? ownerId = null, int? postId = null,
            bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null,
            string sort = null, int? previewLength = null, bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (needLikes != null)
                parameters.Add("need_likes", needLikes.ToApiString());
            if (startCommentId != null)
                parameters.Add("start_comment_id", startCommentId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort);
            if (previewLength != null)
                parameters.Add("preview_length", previewLength.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return _vkontakte.GetAsync<CommentsResponse>("wall.getComments", parameters);
        }

        /// <summary>
        /// Adds a comment to a post on a user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.createComment">wall.createComment</see>
        /// </summary>
        /// <param name="ownerId">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="postId">Post ID.</param>
        /// <param name="fromGroup">
        /// '1' — to post the comment as from the community;; '0' — (default) to post the comment as from
        /// the user.
        /// </param>
        /// <param name="message">(Required if 'attachments' is not set.) Text of the comment.</param>
        /// <param name="replyToComment">ID of comment to reply.</param>
        /// <param name="attachments">
        /// (Required if 'message' is not set.) List of objects attached to the post, in the following format:; 
        /// "%owner_id%_%media_id%, %owner_id%_%media_id%"; 
        /// '' — Type of media attachment:; 
        /// 'photo' — photo; 
        /// 'video' — video; 
        /// 'audio' — audio; 
        /// 'doc' — document; 
        /// '%owner_id%' — Media attachment owner ID.; 
        /// '%media_id%' — Media attachment ID.;
        /// Example:; "photo100172_166443618,photo66748_265827614"
        /// </param>
        /// <param name="stickerId">Sticker ID.</param>
        /// <param name="guid">Unique identifier to avoid repeated comments.</param>
        public Task<CreateCommentResponse> CreateComment(int? ownerId = null, int? postId = null,
            bool? fromGroup = null, string message = null, int? replyToComment = null,
            IEnumerable<string> attachments = null, int? stickerId = null, string guid = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (fromGroup != null)
                parameters.Add("from_group", fromGroup.ToApiString());
            if (message != null)
                parameters.Add("message", message);
            if (replyToComment != null)
                parameters.Add("reply_to_comment", replyToComment.ToApiString());
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (stickerId != null)
                parameters.Add("sticker_id", stickerId.ToApiString());
            if (guid != null)
                parameters.Add("guid", guid);

            return _vkontakte.GetAsync<CreateCommentResponse>("wall.createComment", parameters);
        }

        /// <summary>
        /// Edits a comment on a user wall or community wall.;
        /// Docs: <see href="https://vk.com/dev/wall.editComment">wall.editComment</see>
        /// </summary>
        /// <param name="ownerId">User ID or community ID. Use a negative value to designate a community ID.; ;</param>
        /// <param name="commentId">Comment ID.</param>
        /// <param name="message">New comment text.;</param>
        /// <param name="attachments">
        /// (Required if 'message' is not set.) List of objects attached to the post, in the following format:; 
        /// "%owner_id%_%media_id%, %owner_id%_%media_id%"; 
        /// '' — Type of media attachment:; 
        /// 'photo' — photo; 
        /// 'video' — video; 
        /// 'audio' — audio; 
        /// 'doc' — document; 
        /// '%owner_id%' — Media attachment owner ID.; 
        /// '%media_id%' — Media attachment ID.;
        /// Example:; "photo100172_166443618,photo66748_265827614"
        /// </param>
        public Task<int> EditComment(int? ownerId = null, int? commentId = null, string message = null,
            IEnumerable<string> attachments = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());

            return _vkontakte.GetAsync<int>("wall.editComment", parameters);
        }

        /// <summary>
        /// Deletes a comment on a post on a user wall or community wall.;
        /// Docs: <see href="https://vk.com/dev/wall.deleteComment">wall.deleteComment</see>
        /// </summary>
        /// <param name="ownerId">User ID or community ID. Use a negative value to designate a community ID.;</param>
        /// <param name="commentId">Comment ID.</param>
        public Task<int> DeleteComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());

            return _vkontakte.GetAsync<int>("wall.deleteComment", parameters);
        }

        /// <summary>
        /// Restores a comment deleted from a user wall or community wall.;
        /// Docs: <see href="https://vk.com/dev/wall.restoreComment">wall.restoreComment</see>
        /// </summary>
        /// <param name="ownerId">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="commentId">Comment ID.</param>
        public Task<int> RestoreComment(int? ownerId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());

            return _vkontakte.GetAsync<int>("wall.restoreComment", parameters);
        }

        /// <summary>
        /// Reports (submits a complaint about) a post on a user wall or community wall.;
        /// Docs: <see href="https://vk.com/dev/wall.reportPost">wall.reportPost</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the wall.</param>
        /// <param name="postId">Post ID.</param>
        /// <param name="reason">
        /// Reason for the complaint:; '0' – spam; '1' – child pornography; '2' – extremism; '3' – violence;
        /// '4' – drug propaganda; '5' – adult material; '6' – insult; abuse
        /// </param>
        public Task<int> ReportPost(int? ownerId = null, int? postId = null, int? reason = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (postId != null)
                parameters.Add("post_id", postId.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());

            return _vkontakte.GetAsync<int>("wall.reportPost", parameters);
        }

        /// <summary>
        /// Reports (submits a complaint about) a comment on a post on a user wall or community wall.;
        /// Docs: <see href="https://vk.com/dev/wall.reportComment">wall.reportComment</see>
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the wall.</param>
        /// <param name="commentId">Comment ID.</param>
        /// <param name="reason">
        /// Reason for the complaint:; '0' – spam; '1' – child pornography; '2' – extremism; '3' – violence;
        /// '4' – drug propaganda; '5' – adult material; '6' – insult; abuse
        /// </param>
        public Task<int> ReportComment(int? ownerId = null, int? commentId = null, int? reason = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (reason != null)
                parameters.Add("reason", reason.ToApiString());

            return _vkontakte.GetAsync<int>("wall.reportComment", parameters);
        }
    }
}