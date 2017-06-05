using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Types.Board;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Board API section.
    /// </summary>
    public class Board
    {
        private readonly Vkontakte _vkontakte;

        internal Board(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.getTopics">board.getTopics</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="topicIds">
        /// IDs of topics to be returned (100 maximum). By default, all topics are returned.; If this
        /// parameter is set, the 'order', 'offset', and 'count' parameters are ignored.
        /// </param>
        /// <param name="order">
        /// Sort order:; '1' — by date updated in reverse chronological order.; '2' — by date created in
        /// reverse chronological order.; '-1' — by date updated in chronological order.; '-2' — by date created in
        /// chronological order.; ; If no sort order is specified, topics are returned in the order specified by the group
        /// administrator. Pinned topics are returned first, regardless of the sorting.
        /// </param>
        /// <param name="offset">Offset needed to return a specific subset of topics.</param>
        /// <param name="count">Number of topics to return.</param>
        /// <param name="extended">
        /// '1' — to return information about users who created topics or who posted there last; '0' — to
        /// return no additional fields (default)
        /// </param>
        /// <param name="preview">
        /// '1' — to return the first comment in each topic;; '2' — to return the last comment in each
        /// topic;; '0' — to return no comments.; ; By default: '0'.
        /// </param>
        /// <param name="previewLength">
        /// Number of characters after which to truncate the previewed comment. To preview the full
        /// comment, specify '0'.
        /// </param>
        public Task<ApiItemsResponse<Topic>> GetTopics(int? groupId = null, IEnumerable<int?> topicIds = null,
            int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null,
            int? previewLength = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicIds != null)
                parameters.Add("topic_ids", topicIds.ToApiString());
            if (order != null)
                parameters.Add("order", order.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (preview != null)
                parameters.Add("preview", preview.ToApiString());
            if (previewLength != null)
                parameters.Add("preview_length", previewLength.ToApiString());

            return _vkontakte.GetAsync<ApiItemsResponse<Topic>>("board.getTopics", parameters);
        }

        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.getComments">board.getComments</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="topicId">Topic ID.</param>
        /// <param name="needLikes">'1' — to return the 'likes' field; '0' — not to return the 'likes' field (default)</param>
        /// <param name="startCommentId"></param>
        /// <param name="offset">Offset needed to return a specific subset of comments.</param>
        /// <param name="count">Number of comments to return.</param>
        /// <param name="extended">
        /// '1' — to return information about users who posted comments; '0' — to return no additional
        /// fields (default)
        /// </param>
        /// <param name="sort">
        /// Sort order:; 'asc' — by creation date in chronological order; 'desc' — by creation date in reverse
        /// chronological order;
        /// </param>
        public Task<ApiItemsResponse<TopicComment>> GetComments(int? groupId = null, int? topicId = null,
            bool? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null,
            bool? extended = null, string sort = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            if (needLikes != null)
                parameters.Add("need_likes", needLikes.ToApiString());
            if (startCommentId != null)
                parameters.Add("start_comment_id", startCommentId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (sort != null)
                parameters.Add("sort", sort);

            return _vkontakte.GetAsync<ApiItemsResponse<TopicComment>>("board.getComments", parameters);
        }

        /// <summary>
        /// Creates a new topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.addTopic">board.addTopic</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="title">Topic title.</param>
        /// <param name="text">Text of the topic.</param>
        /// <param name="fromGroup">
        /// For a community:; '1' — to post the topic as by the community; '0' — to post the topic as by
        /// the user (default)
        /// </param>
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
        public Task<int?> AddTopic(int? groupId = null, string title = null, string text = null,
            bool? fromGroup = null, IEnumerable<string> attachments = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (text != null)
                parameters.Add("text", text);
            if (fromGroup != null)
                parameters.Add("from_group", fromGroup.ToApiString());
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());

            return _vkontakte.GetAsync<int?>("board.addTopic", parameters);
        }

        /// <summary>
        /// Adds a comment on a topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.createComment">board.createComment</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="topicId">ID of the topic to be commented on.</param>
        /// <param name="message">(Required if 'attachments' is not set.) Text of the comment.</param>
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
        /// <param name="fromGroup">
        /// '1' — to post the comment as by the community; '0' — to post the comment as by the user
        /// (default)
        /// </param>
        /// <param name="stickerId">Sticker ID.</param>
        /// <param name="guid">Unique identifier to avoid repeated comments.</param>
        public Task<int?> CreateComment(int? groupId = null, int? topicId = null, string message = null,
            IEnumerable<string> attachments = null, bool? fromGroup = null, int? stickerId = null, string guid = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (fromGroup != null)
                parameters.Add("from_group", fromGroup.ToApiString());
            if (stickerId != null)
                parameters.Add("sticker_id", stickerId.ToApiString());
            if (guid != null)
                parameters.Add("guid", guid);

            return _vkontakte.GetAsync<int?>("board.createComment", parameters);
        }

        /// <summary>
        /// Deletes a topic from a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.deleteTopic">board.deleteTopic</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="topicId">Topic ID.</param>
        public Task<int> DeleteTopic(int? groupId = null, int? topicId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());

            return _vkontakte.GetAsync<int>("board.deleteTopic", parameters);
        }

        /// <summary>
        /// Edits the title of a topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.editTopic">board.editTopic</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="topicId">Topic ID.</param>
        /// <param name="title">New title of the topic.</param>
        public Task<int> EditTopic(int? groupId = null, int? topicId = null, string title = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            if (title != null)
                parameters.Add("title", title);

            return _vkontakte.GetAsync<int>("board.editTopic", parameters);
        }

        /// <summary>
        /// Edits a comment on a topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.editComment">board.editComment</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="topicId">Topic ID.</param>
        /// <param name="commentId">ID of the comment on the topic.</param>
        /// <param name="message">(Required if 'attachments' is not set). New comment text.</param>
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
        public Task<int> EditComment(int? groupId = null, int? topicId = null, int? commentId = null,
            string message = null, IEnumerable<string> attachments = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());

            return _vkontakte.GetAsync<int>("board.editComment", parameters);
        }

        /// <summary>
        /// Restores a comment deleted from a topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.restoreComment">board.restoreComment</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="topicId">Topic ID.</param>
        /// <param name="commentId">Comment ID.</param>
        public Task<int> RestoreComment(int? groupId = null, int? topicId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());

            return _vkontakte.GetAsync<int>("board.restoreComment", parameters);
        }

        /// <summary>
        /// Deletes a comment on a topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.deleteComment">board.deleteComment</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="topicId">Topic ID.</param>
        /// <param name="commentId">Comment ID.</param>
        public Task<int> DeleteComment(int? groupId = null, int? topicId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());

            return _vkontakte.GetAsync<int>("board.deleteComment", parameters);
        }

        /// <summary>
        /// Re-opens a previously closed topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.openTopic">board.openTopic</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="topicId">Topic ID.</param>
        public Task<int> OpenTopic(int? groupId = null, int? topicId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());

            return _vkontakte.GetAsync<int>("board.openTopic", parameters);
        }

        /// <summary>
        /// Closes a topic on a community's discussion board so that comments cannot be posted.
        /// Docs: <see href="https://vk.com/dev/board.closeTopic">board.closeTopic</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="topicId">Topic ID.</param>
        public Task<int> CloseTopic(int? groupId = null, int? topicId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());

            return _vkontakte.GetAsync<int>("board.closeTopic", parameters);
        }

        /// <summary>
        /// Pins a topic (fixes its place) to the top of a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.fixTopic">board.fixTopic</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="topicId">Topic ID.</param>
        public Task<int> FixTopic(int? groupId = null, int? topicId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());

            return _vkontakte.GetAsync<int>("board.fixTopic", parameters);
        }

        /// <summary>
        /// Unpins a pinned topic from the top of a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.unfixTopic">board.unfixTopic</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the discussion board.</param>
        /// <param name="topicId">Topic ID.</param>
        public Task<int> UnfixTopic(int? groupId = null, int? topicId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());

            return _vkontakte.GetAsync<int>("board.unfixTopic", parameters);
        }
    }
}