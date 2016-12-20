using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Board API section.
    /// </summary>
    public class Board
    {
        private Vkontakte _vkontakte;

        internal Board(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of topics on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.getTopics">board.getTopics</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="topic_ids">IDs of topics to be returned (100 maximum). By default, all topics are returned.; If this parameter is set, the 'order', 'offset', and 'count' parameters are ignored.</param>
        /// <param name="order">Sort order:; '1' — by date updated in reverse chronological order.; '2' — by date created in reverse chronological order.; '-1' — by date updated in chronological order.; '-2' — by date created in chronological order.; ; If no sort order is specified, topics are returned in the order specified by the group administrator. Pinned topics are returned first, regardless of the sorting.</param>
        /// <param name="offset">Offset needed to return a specific subset of topics.</param>
        /// <param name="count">Number of topics to return.</param>
        /// <param name="extended">'1' — to return information about users who created topics or who posted there last; '0' — to return no additional fields (default)</param>
        /// <param name="preview">'1' — to return the first comment in each topic;; '2' — to return the last comment in each topic;; '0' — to return no comments.; ; By default: '0'.</param>
        /// <param name="preview_length">Number of characters after which to truncate the previewed comment. To preview the full comment, specify '0'.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Board.Topic>> GetTopics(int? group_id = null, IEnumerable<int?> topic_ids = null, int? order = null, int? offset = null, int? count = null, bool? extended = null, int? preview = null, int? preview_length = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (topic_ids != null)
                parameters.Add("topic_ids", string.Join(",", topic_ids));
            if (order != null)
                parameters.Add("order", order.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (extended != null)
                parameters.Add("extended", extended.ToString());
            if (preview != null)
                parameters.Add("preview", preview.ToString());
            if (preview_length != null)
                parameters.Add("preview_length", preview_length.ToString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Board.Topic>>("board.getTopics", parameters);
        }

        /// <summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.getComments">board.getComments</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="topic_id">Topic ID.</param>
        /// <param name="need_likes">'1' — to return the 'likes' field; '0' — not to return the 'likes' field (default)</param>
        /// <param name="start_comment_id"></param>
        /// <param name="offset">Offset needed to return a specific subset of comments.</param>
        /// <param name="count">Number of comments to return.</param>
        /// <param name="extended">'1' — to return information about users who posted comments; '0' — to return no additional fields (default)</param>
        /// <param name="sort">Sort order:; 'asc' — by creation date in chronological order; 'desc' — by creation date in reverse chronological order;</param>
        public async Task<ApiItemsResponse<VkLib.Types.Board.TopicComment>> GetComments(int? group_id = null, int? topic_id = null, bool? need_likes = null, int? start_comment_id = null, int? offset = null, int? count = null, bool? extended = null, string sort = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (topic_id != null)
                parameters.Add("topic_id", topic_id.ToString());
            if (need_likes != null)
                parameters.Add("need_likes", need_likes.ToString());
            if (start_comment_id != null)
                parameters.Add("start_comment_id", start_comment_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (extended != null)
                parameters.Add("extended", extended.ToString());
            if (sort != null)
                parameters.Add("sort", sort);

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Board.TopicComment>>("board.getComments", parameters);
        }

        /// <summary>
        /// Creates a new topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.addTopic">board.addTopic</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="title">Topic title.</param>
        /// <param name="text">Text of the topic.</param>
        /// <param name="from_group">For a community:; '1' — to post the topic as by the community; '0' — to post the topic as by the user (default)</param>
        /// <param name="attachments">List of media objects attached to the topic, in the following format:; "<owner_id>_<media_id>,<owner_id>_<media_id>"; '' — Type of media object:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; '<owner_id>' — ID of the media owner. ; '<media_id>' — Media ID.; ; Example:; "photo100172_166443618,photo66748_265827614"; ; "NOTE: If you try to attach more than one reference, an error will be thrown.";</param>
        public async Task<int?> AddTopic(int? group_id = null, string title = null, string text = null, bool? from_group = null, IEnumerable<string> attachments = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (title != null)
                parameters.Add("title", title);
            if (text != null)
                parameters.Add("text", text);
            if (from_group != null)
                parameters.Add("from_group", from_group.ToString());
            if (attachments != null)
                parameters.Add("attachments", string.Join(",", attachments));

            return await _vkontakte.GetAsync<int?>("board.addTopic", parameters);
        }

        /// <summary>
        /// Adds a comment on a topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.createComment">board.createComment</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="topic_id">ID of the topic to be commented on.</param>
        /// <param name="message">(Required if 'attachments' is not set.) Text of the comment.</param>
        /// <param name="attachments">(Required if 'text' is not set.) List of media objects attached to the comment, in the following format:; "<owner_id>_<media_id>,<owner_id>_<media_id>"; '' — Type of media object:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; '<owner_id>' — ID of the media owner. ; '<media_id>' — Media ID.</param>
        /// <param name="from_group">'1' — to post the comment as by the community; '0' — to post the comment as by the user (default)</param>
        /// <param name="sticker_id">Sticker ID.</param>
        /// <param name="guid">Unique identifier to avoid repeated comments.</param>
        public async Task<int?> CreateComment(int? group_id = null, int? topic_id = null, string message = null, IEnumerable<string> attachments = null, bool? from_group = null, int? sticker_id = null, string guid = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (topic_id != null)
                parameters.Add("topic_id", topic_id.ToString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", string.Join(",", attachments));
            if (from_group != null)
                parameters.Add("from_group", from_group.ToString());
            if (sticker_id != null)
                parameters.Add("sticker_id", sticker_id.ToString());
            if (guid != null)
                parameters.Add("guid", guid);

            return await _vkontakte.GetAsync<int?>("board.createComment", parameters);
        }

        /// <summary>
        /// Deletes a topic from a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.deleteTopic">board.deleteTopic</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="topic_id">Topic ID.</param>
        public async Task<int> DeleteTopic(int? group_id = null, int? topic_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (topic_id != null)
                parameters.Add("topic_id", topic_id.ToString());

            return await _vkontakte.GetAsync<int>("board.deleteTopic", parameters);
        }

        /// <summary>
        /// Edits the title of a topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.editTopic">board.editTopic</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="topic_id">Topic ID.</param>
        /// <param name="title">New title of the topic.</param>
        public async Task<int> EditTopic(int? group_id = null, int? topic_id = null, string title = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (topic_id != null)
                parameters.Add("topic_id", topic_id.ToString());
            if (title != null)
                parameters.Add("title", title);

            return await _vkontakte.GetAsync<int>("board.editTopic", parameters);
        }

        /// <summary>
        /// Edits a comment on a topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.editComment">board.editComment</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="topic_id">Topic ID.</param>
        /// <param name="comment_id">ID of the comment on the topic.</param>
        /// <param name="message">(Required if 'attachments' is not set). New comment text.</param>
        /// <param name="attachments">(Required if 'message' is not set.) List of media objects attached to the comment, in the following format:; "<owner_id>_<media_id>,<owner_id>_<media_id>"; '' — Type of media object:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; '<owner_id>' — ID of the media owner. ; '<media_id>' — Media ID.; ; Example:; "photo100172_166443618,photo66748_265827614"</param>
        public async Task<int> EditComment(int? group_id = null, int? topic_id = null, int? comment_id = null, string message = null, IEnumerable<string> attachments = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (topic_id != null)
                parameters.Add("topic_id", topic_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());
            if (message != null)
                parameters.Add("message", message);
            if (attachments != null)
                parameters.Add("attachments", string.Join(",", attachments));

            return await _vkontakte.GetAsync<int>("board.editComment", parameters);
        }

        /// <summary>
        /// Restores a comment deleted from a topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.restoreComment">board.restoreComment</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="topic_id">Topic ID.</param>
        /// <param name="comment_id">Comment ID.</param>
        public async Task<int> RestoreComment(int? group_id = null, int? topic_id = null, int? comment_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (topic_id != null)
                parameters.Add("topic_id", topic_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());

            return await _vkontakte.GetAsync<int>("board.restoreComment", parameters);
        }

        /// <summary>
        /// Deletes a comment on a topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.deleteComment">board.deleteComment</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="topic_id">Topic ID.</param>
        /// <param name="comment_id">Comment ID.</param>
        public async Task<int> DeleteComment(int? group_id = null, int? topic_id = null, int? comment_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (topic_id != null)
                parameters.Add("topic_id", topic_id.ToString());
            if (comment_id != null)
                parameters.Add("comment_id", comment_id.ToString());

            return await _vkontakte.GetAsync<int>("board.deleteComment", parameters);
        }

        /// <summary>
        /// Re-opens a previously closed topic on a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.openTopic">board.openTopic</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="topic_id">Topic ID.</param>
        public async Task<int> OpenTopic(int? group_id = null, int? topic_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (topic_id != null)
                parameters.Add("topic_id", topic_id.ToString());

            return await _vkontakte.GetAsync<int>("board.openTopic", parameters);
        }

        /// <summary>
        /// Closes a topic on a community's discussion board so that comments cannot be posted.
        /// Docs: <see href="https://vk.com/dev/board.closeTopic">board.closeTopic</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="topic_id">Topic ID.</param>
        public async Task<int> CloseTopic(int? group_id = null, int? topic_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (topic_id != null)
                parameters.Add("topic_id", topic_id.ToString());

            return await _vkontakte.GetAsync<int>("board.closeTopic", parameters);
        }

        /// <summary>
        /// Pins a topic (fixes its place) to the top of a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.fixTopic">board.fixTopic</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="topic_id">Topic ID.</param>
        public async Task<int> FixTopic(int? group_id = null, int? topic_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (topic_id != null)
                parameters.Add("topic_id", topic_id.ToString());

            return await _vkontakte.GetAsync<int>("board.fixTopic", parameters);
        }

        /// <summary>
        /// Unpins a pinned topic from the top of a community's discussion board.
        /// Docs: <see href="https://vk.com/dev/board.unfixTopic">board.unfixTopic</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the discussion board.</param>
        /// <param name="topic_id">Topic ID.</param>
        public async Task<int> UnfixTopic(int? group_id = null, int? topic_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (topic_id != null)
                parameters.Add("topic_id", topic_id.ToString());

            return await _vkontakte.GetAsync<int>("board.unfixTopic", parameters);
        }

    }
}
