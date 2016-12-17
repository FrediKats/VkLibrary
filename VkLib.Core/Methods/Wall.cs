using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Wall API section.
    /// </summary>
    public class Wall
    {
        private Vkontakte _vkontakte;

        internal Wall(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of posts from user or community walls by their IDs.
        /// Docs: <see href="https://vk.com/dev/wall.getById">wall.getById</see>
        /// </summary>
        /// <param name="posts">User or community IDs and post IDs, separated by underscores. Use a negative value to designate a community ID. Example:; "93388_21539,93388_20904,2943_4276,-1_1"</param>
        /// <param name="extended">'1' — to return user and community objects needed to display posts; '0' — no additional fields are returned (default)</param>
        /// <param name="copy_history_depth">Sets the number of parent elements to include in the array 'copy_history' that is returned if the post is a repost from another wall.</param>
        /// <param name="fields"></param>
        public async Task<object> GetById(IEnumerable<string> posts = null, bool? extended = null, int? copy_history_depth = null, IEnumerable<string> fields = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (posts != null)
                parameters.Add("posts", string.Join(",", posts));
            if (extended != null)
                parameters.Add("extended", extended.ToString());
            if (copy_history_depth != null)
                parameters.Add("copy_history_depth", copy_history_depth.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));

            return await _vkontakte.GetAsync<object>("wall.getById", parameters);
        }

        /// <summary>
        /// Adds a new post on a user wall or community wall. Can also be used to publish suggested or scheduled posts.
        /// Docs: <see href="https://vk.com/dev/wall.post">wall.post</see>
        /// </summary>
        /// <param name="owner_id">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="friends_only">'1' — post will be available to friends only; '0' — post will be available to all users (default)</param>
        /// <param name="from_group">For a community:; '1' — post will be published by the community; '0' — post will be published by the user (default)</param>
        /// <param name="message">(Required if 'attachments' is not set.) Text of the post.</param>
        /// <param name="attachments">(Required if 'message' is not set.) List of objects attached to the post, in the following format:; "<owner_id>_<media_id>,<owner_id>_<media_id>"; '' — Type of media attachment:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; 'page' — wiki-page; 'note' — note; 'poll' — poll; 'album' — photo album; '<owner_id>' — ID of the media application owner. ; '<media_id>' — Media application ID.; ; Example:; "photo100172_166443618,photo66748_265827614"; May contain a link to an external page to include in the post. Example:; "photo66748_265827614,http://habrahabr.ru"; "NOTE: If more than one link is being attached, an error will be thrown."</param>
        /// <param name="services">List of services or websites the update will be exported to, if the user has so requested. Sample values: 'twitter', 'facebook'.</param>
        /// <param name="signed">Only for posts in communities with 'from_group' set to '1':; '1' — post will be signed with the name of the posting user; '0' — post will not be signed (default)</param>
        /// <param name="publish_date">Publication date (in Unix time). If used, posting will be delayed until the set time.</param>
        /// <param name="lat">Geographical latitude of a check-in, in degrees (from -90 to 90).</param>
        /// <param name="long">Geographical longitude of a check-in, in degrees (from -180 to 180).</param>
        /// <param name="place_id">ID of the location where the user was tagged.</param>
        /// <param name="post_id">Post ID. Used for publishing of scheduled and suggested posts.</param>
        /// <param name="guid"></param>
        /// <param name="mark_as_ads"></param>
        public async Task<object> Post(int? owner_id = null, bool? friends_only = null, bool? from_group = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, int? publish_date = null, uint? lat = null, uint? long = null, int? place_id = null, int? post_id = null, string guid = null, bool? mark_as_ads = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (friends_only != null)
                parameters.Add("friends_only", friends_only.ToString());
            if (from_group != null)
                parameters.Add("from_group", from_group.ToString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", string.Join(",", attachments));
            if (services != null)
                parameters.Add("services", services);
            if (signed != null)
                parameters.Add("signed", signed.ToString());
            if (publish_date != null)
                parameters.Add("publish_date", publish_date.ToString());
            if (lat != null)
                parameters.Add("lat", lat.ToString());
            if (long != null)
                parameters.Add("long", long.ToString());
            if (place_id != null)
                parameters.Add("place_id", place_id.ToString());
            if (post_id != null)
                parameters.Add("post_id", post_id.ToString());
            if (guid != null)
                parameters.Add("guid", guid);
            if (mark_as_ads != null)
                parameters.Add("mark_as_ads", mark_as_ads.ToString());

            return await _vkontakte.GetAsync<object>("wall.post", parameters);
        }

        /// <summary>
        /// Reposts (copies) an object to a user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.repost">wall.repost</see>
        /// </summary>
        /// <param name="object">ID of the object to be reposted on the wall. Example:; "wall66748_3675"</param>
        /// <param name="message">Comment to be added along with the reposted object.</param>
        /// <param name="group_id">Target community ID when reposting to a community.</param>
        /// <param name="mark_as_ads"></param>
        public async Task<object> Repost(string object = null, string message = null, int? group_id = null, bool? mark_as_ads = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (object != null)
                parameters.Add("object", object);
            if (message != null)
                parameters.Add("message", message);
            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (mark_as_ads != null)
                parameters.Add("mark_as_ads", mark_as_ads.ToString());

            return await _vkontakte.GetAsync<object>("wall.repost", parameters);
        }

        /// <summary>
        /// Returns information about reposts of a post on user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.getReposts">wall.getReposts</see>
        /// </summary>
        /// <param name="owner_id">User ID or community ID. By default, current user ID. Use a negative value to designate a community ID.</param>
        /// <param name="post_id">Post ID.</param>
        /// <param name="offset">Offset needed to return a specific subset of reposts.</param>
        /// <param name="count">Number of reposts to return.</param>
        public async Task<object> GetReposts(int? owner_id = null, int? post_id = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (post_id != null)
                parameters.Add("post_id", post_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<object>("wall.getReposts", parameters);
        }

        /// <summary>
        /// Edits a post on a user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.edit">wall.edit</see>
        /// </summary>
        /// <param name="owner_id">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="post_id">Post ID.</param>
        /// <param name="friends_only">(Applies only when editing a scheduled post.); '1' — post will be available to friends only; '0' — post will be available to all users (default)</param>
        /// <param name="message">(Required if 'attachments' is not set.) Text of the post.</param>
        /// <param name="attachments">(Required if 'message' is not set.) List of objects attached to the post, in the following format:; "<owner_id>_<media_id>,<owner_id>_<media_id>"; '' — Type of media attachment:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; '<owner_id>' — ID of the media application owner.; '<media_id>' — Media application ID. ; ; Example:; "photo100172_166443618,photo66748_265827614"; May contain a link to an external page to include in the post. Example:; "photo66748_265827614,http://habrahabr.ru"; "NOTE: If more than one link is being attached, an error is thrown."</param>
        /// <param name="services">(Applies only to a scheduled post.) List of services or websites where status will be updated, if the user has so requested. Sample values: 'twitter', 'facebook'.</param>
        /// <param name="signed">(Applies only to a post that was created "as community" on a community wall.); '1' — to add the signature of the user who created the post</param>
        /// <param name="publish_date">(Applies only to a scheduled post.) Publication date (in Unix time). If used, posting will be delayed until the set time.</param>
        /// <param name="lat">Geographical latitude of the check-in, in degrees (from -90 to 90).</param>
        /// <param name="long">Geographical longitude of the check-in, in degrees (from -180 to 180).</param>
        /// <param name="place_id">ID of the location where the user was tagged.</param>
        /// <param name="mark_as_ads"></param>
        public async Task<object> Edit(int? owner_id = null, int? post_id = null, bool? friends_only = null, string message = null, IEnumerable<string> attachments = null, string services = null, bool? signed = null, int? publish_date = null, uint? lat = null, uint? long = null, int? place_id = null, bool? mark_as_ads = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (post_id != null)
                parameters.Add("post_id", post_id.ToString());
            if (friends_only != null)
                parameters.Add("friends_only", friends_only.ToString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", string.Join(",", attachments));
            if (services != null)
                parameters.Add("services", services);
            if (signed != null)
                parameters.Add("signed", signed.ToString());
            if (publish_date != null)
                parameters.Add("publish_date", publish_date.ToString());
            if (lat != null)
                parameters.Add("lat", lat.ToString());
            if (long != null)
                parameters.Add("long", long.ToString());
            if (place_id != null)
                parameters.Add("place_id", place_id.ToString());
            if (mark_as_ads != null)
                parameters.Add("mark_as_ads", mark_as_ads.ToString());

            return await _vkontakte.GetAsync<object>("wall.edit", parameters);
        }

        /// <summary>
        /// Deletes a post from a user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.delete">wall.delete</see>
        /// </summary>
        /// <param name="owner_id">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="post_id">ID of the post to be deleted.</param>
        public async Task<object> Delete(int? owner_id = null, int? post_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (post_id != null)
                parameters.Add("post_id", post_id.ToString());

            return await _vkontakte.GetAsync<object>("wall.delete", parameters);
        }

        /// <summary>
        /// Restores a post deleted from a user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.restore">wall.restore</see>
        /// </summary>
        /// <param name="owner_id">User ID or community ID from whose wall the post was deleted. Use a negative value to designate a community ID.</param>
        /// <param name="post_id">ID of the post to be restored.</param>
        public async Task<object> Restore(int? owner_id = null, int? post_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (post_id != null)
                parameters.Add("post_id", post_id.ToString());

            return await _vkontakte.GetAsync<object>("wall.restore", parameters);
        }

        /// <summary>
        /// Pins the post on wall.
        /// Docs: <see href="https://vk.com/dev/wall.pin">wall.pin</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the wall. By default, current user ID. Use a negative value to designate a community ID.</param>
        /// <param name="post_id">Post ID.</param>
        public async Task<object> Pin(int? owner_id = null, int? post_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (post_id != null)
                parameters.Add("post_id", post_id.ToString());

            return await _vkontakte.GetAsync<object>("wall.pin", parameters);
        }

        /// <summary>
        /// Unpins the post on wall.
        /// Docs: <see href="https://vk.com/dev/wall.unpin">wall.unpin</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the wall. By default, current user ID. Use a negative value to designate a community ID.</param>
        /// <param name="post_id">Post ID.</param>
        public async Task<object> Unpin(int? owner_id = null, int? post_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (post_id != null)
                parameters.Add("post_id", post_id.ToString());

            return await _vkontakte.GetAsync<object>("wall.unpin", parameters);
        }

        /// <summary>
        /// Returns a list of comments on a post on a user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.getComments">wall.getComments</see>
        /// </summary>
        /// <param name="owner_id">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="post_id">Post ID.</param>
        /// <param name="need_likes">'1' — to return the 'likes' field; '0' — not to return the 'likes' field (default)</param>
        /// <param name="start_comment_id"></param>
        /// <param name="offset">Offset needed to return a specific subset of comments.</param>
        /// <param name="count">Number of comments to return (maximum 100).</param>
        /// <param name="sort">Sort order:; 'asc' — chronological; 'desc' — reverse chronological</param>
        /// <param name="preview_length">Number of characters at which to truncate comments when previewed. By default, '90'. Specify '0' if you do not want to truncate comments.;</param>
        /// <param name="extended"></param>
        public async Task<object> GetComments(int? owner_id = null, int? post_id = null, bool? need_likes = null, int? start_comment_id = null, int? offset = null, int? count = null, string sort = null, int? preview_length = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (post_id != null)
                parameters.Add("post_id", post_id.ToString());
            if (need_likes != null)
                parameters.Add("need_likes", need_likes.ToString());
            if (start_comment_id != null)
                parameters.Add("start_comment_id", start_comment_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (sort != null)
                parameters.Add("sort", sort);
            if (preview_length != null)
                parameters.Add("preview_length", preview_length.ToString());
            if (extended != null)
                parameters.Add("extended", extended.ToString());

            return await _vkontakte.GetAsync<object>("wall.getComments", parameters);
        }

        /// <summary>
        /// Adds a comment to a post on a user wall or community wall.
        /// Docs: <see href="https://vk.com/dev/wall.createComment">wall.createComment</see>
        /// </summary>
        /// <param name="owner_id">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="post_id">Post ID.</param>
        /// <param name="from_group">'1' — to post the comment as from the community;; '0' — (default) to post the comment as from the user.</param>
        /// <param name="message">(Required if 'attachments' is not set.) Text of the comment.</param>
        /// <param name="reply_to_comment">ID of comment to reply.</param>
        /// <param name="attachments">(Required if 'message' is not set.) List of media objects attached to the comment, in the following format:; "<owner_id>_<media_id>,<owner_id>_<media_id>"; '' — Type of media ojbect:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; '<owner_id>' — ID of the media owner.; '<media_id>' — Media ID. ; ; For example:; "photo100172_166443618,photo66748_265827614"</param>
        /// <param name="sticker_id">Sticker ID.</param>
        /// <param name="guid">Unique identifier to avoid repeated comments.</param>
        public async Task<object> CreateComment(int? owner_id = null, int? post_id = null, bool? from_group = null, string message = null, int? reply_to_comment = null, IEnumerable<string> attachments = null, int? sticker_id = null, string guid = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (post_id != null)
                parameters.Add("post_id", post_id.ToString());
            if (from_group != null)
                parameters.Add("from_group", from_group.ToString());
            if (message != null)
                parameters.Add("message", message);
            if (reply_to_comment != null)
                parameters.Add("reply_to_comment", reply_to_comment.ToString());
            if (attachments != null)
                parameters.Add("attachments", string.Join(",", attachments));
            if (sticker_id != null)
                parameters.Add("sticker_id", sticker_id.ToString());
            if (guid != null)
                parameters.Add("guid", guid);

            return await _vkontakte.GetAsync<object>("wall.createComment", parameters);
        }

        /// <summary>
        /// Edits a comment on a user wall or community wall.;
        /// Docs: <see href="https://vk.com/dev/wall.editComment">wall.editComment</see>
        /// </summary>
        /// <param name="owner_id">User ID or community ID. Use a negative value to designate a community ID.; ;</param>
        /// <param name="comment_id">Comment ID.</param>
        /// <param name="message">New comment text.;</param>
        /// <param name="attachments">List of objects attached to the comment, in the following format:; ; "<owner_id>_<media_id>,<owner_id>_<media_id>"; '' — Type of media attachment:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; '<owner_id>' — ID of the media attachment owner.; '<media_id>' — Media attachment ID. ; ; For example:; "photo100172_166443618,photo66748_265827614"</param>
        public async Task<object> EditComment(int? owner_id = null, int? comment_id = null, string message = null, IEnumerable<string> attachments = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", string.Join(",", attachments));

            return await _vkontakte.GetAsync<object>("wall.editComment", parameters);
        }

        /// <summary>
        /// Deletes a comment on a post on a user wall or community wall.;
        /// Docs: <see href="https://vk.com/dev/wall.deleteComment">wall.deleteComment</see>
        /// </summary>
        /// <param name="owner_id">User ID or community ID. Use a negative value to designate a community ID.;</param>
        /// <param name="comment_id">Comment ID.</param>
        public async Task<object> DeleteComment(int? owner_id = null, int? comment_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());

            return await _vkontakte.GetAsync<object>("wall.deleteComment", parameters);
        }

        /// <summary>
        /// Restores a comment deleted from a user wall or community wall.;
        /// Docs: <see href="https://vk.com/dev/wall.restoreComment">wall.restoreComment</see>
        /// </summary>
        /// <param name="owner_id">User ID or community ID. Use a negative value to designate a community ID.</param>
        /// <param name="comment_id">Comment ID.</param>
        public async Task<object> RestoreComment(int? owner_id = null, int? comment_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());

            return await _vkontakte.GetAsync<object>("wall.restoreComment", parameters);
        }

        /// <summary>
        /// Reports (submits a complaint about) a post on a user wall or community wall.;
        /// Docs: <see href="https://vk.com/dev/wall.reportPost">wall.reportPost</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the wall.</param>
        /// <param name="post_id">Post ID.</param>
        /// <param name="reason">Reason for the complaint:; '0' – spam; '1' – child pornography; '2' – extremism; '3' – violence; '4' – drug propaganda; '5' – adult material; '6' – insult; abuse</param>
        public async Task<object> ReportPost(int? owner_id = null, int? post_id = null, int? reason = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (post_id != null)
                parameters.Add("post_id", post_id.ToString());
            if (reason != null)
                parameters.Add("reason", reason.ToString());

            return await _vkontakte.GetAsync<object>("wall.reportPost", parameters);
        }

        /// <summary>
        /// Reports (submits a complaint about) a comment on a post on a user wall or community wall.;
        /// Docs: <see href="https://vk.com/dev/wall.reportComment">wall.reportComment</see>
        /// </summary>
        /// <param name="owner_id">ID of the user or community that owns the wall.</param>
        /// <param name="comment_id">Comment ID.</param>
        /// <param name="reason">Reason for the complaint:; '0' – spam; '1' – child pornography; '2' – extremism; '3' – violence; '4' – drug propaganda; '5' – adult material; '6' – insult; abuse</param>
        public async Task<object> ReportComment(int? owner_id = null, int? comment_id = null, int? reason = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());
            if (reason != null)
                parameters.Add("reason", reason.ToString());

            return await _vkontakte.GetAsync<object>("wall.reportComment", parameters);
        }

    }
}
