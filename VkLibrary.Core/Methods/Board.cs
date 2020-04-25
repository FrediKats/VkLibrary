using VkApi.Wrapper.Objects;
using VkApi.Wrapper.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Methods
{
    public class Board
    {
        private readonly Vkontakte _vkontakte;

        internal Board(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Creates a new topic on a community's discussion board.
        ///</summary>
        public Task<int> AddTopic(int? groupId = null, String title = null, String text = null, Boolean? fromGroup = null, String[] attachments = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            if (text != null)
                parameters.Add("text", text.ToApiString());
            if (fromGroup != null)
                parameters.Add("from_group", fromGroup.ToApiString());
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            return _vkontakte.RequestAsync<int>("board.addTopic", parameters);
        }

        ///<summary>
        /// Closes a topic on a community's discussion board so that comments cannot be posted.
        ///</summary>
        public Task<BaseOkResponse> CloseTopic(int? groupId = null, int? topicId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("board.closeTopic", parameters);
        }

        ///<summary>
        /// Adds a comment on a topic on a community's discussion board.
        ///</summary>
        public Task<int> CreateComment(int? groupId = null, int? topicId = null, String message = null, String[] attachments = null, Boolean? fromGroup = null, int? stickerId = null, String guid = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            if (fromGroup != null)
                parameters.Add("from_group", fromGroup.ToApiString());
            if (stickerId != null)
                parameters.Add("sticker_id", stickerId.ToApiString());
            if (guid != null)
                parameters.Add("guid", guid.ToApiString());
            return _vkontakte.RequestAsync<int>("board.createComment", parameters);
        }

        ///<summary>
        /// Deletes a comment on a topic on a community's discussion board.
        ///</summary>
        public Task<BaseOkResponse> DeleteComment(int? groupId = null, int? topicId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("board.deleteComment", parameters);
        }

        ///<summary>
        /// Deletes a topic from a community's discussion board.
        ///</summary>
        public Task<BaseOkResponse> DeleteTopic(int? groupId = null, int? topicId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("board.deleteTopic", parameters);
        }

        ///<summary>
        /// Edits a comment on a topic on a community's discussion board.
        ///</summary>
        public Task<BaseOkResponse> EditComment(int? groupId = null, int? topicId = null, int? commentId = null, String message = null, String[] attachments = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (attachments != null)
                parameters.Add("attachments", attachments.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("board.editComment", parameters);
        }

        ///<summary>
        /// Edits the title of a topic on a community's discussion board.
        ///</summary>
        public Task<BaseOkResponse> EditTopic(int? groupId = null, int? topicId = null, String title = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("board.editTopic", parameters);
        }

        ///<summary>
        /// Pins a topic (fixes its place) to the top of a community's discussion board.
        ///</summary>
        public Task<BaseOkResponse> FixTopic(int? groupId = null, int? topicId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("board.fixTopic", parameters);
        }

        ///<summary>
        /// Returns a list of comments on a topic on a community's discussion board.
        ///</summary>
        public Task<BoardGetCommentsResponse> GetComments(int? groupId = null, int? topicId = null, Boolean? needLikes = null, int? startCommentId = null, int? offset = null, int? count = null, Boolean? extended = null, String sort = null)
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
                parameters.Add("sort", sort.ToApiString());
            return _vkontakte.RequestAsync<BoardGetCommentsResponse>("board.getComments", parameters);
        }

        ///<summary>
        /// Returns a list of topics on a community's discussion board.
        ///</summary>
        public Task<BoardGetTopicsResponse> GetTopics(int? groupId = null, int[] topicIds = null, int? order = null, int? offset = null, int? count = null, Boolean? extended = null, int? preview = null, int? previewLength = null)
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
            return _vkontakte.RequestAsync<BoardGetTopicsResponse>("board.getTopics", parameters);
        }

        ///<summary>
        /// Re-opens a previously closed topic on a community's discussion board.
        ///</summary>
        public Task<BaseOkResponse> OpenTopic(int? groupId = null, int? topicId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("board.openTopic", parameters);
        }

        ///<summary>
        /// Restores a comment deleted from a topic on a community's discussion board.
        ///</summary>
        public Task<BaseOkResponse> RestoreComment(int? groupId = null, int? topicId = null, int? commentId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            if (commentId != null)
                parameters.Add("comment_id", commentId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("board.restoreComment", parameters);
        }

        ///<summary>
        /// Unpins a pinned topic from the top of a community's discussion board.
        ///</summary>
        public Task<BaseOkResponse> UnfixTopic(int? groupId = null, int? topicId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (topicId != null)
                parameters.Add("topic_id", topicId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("board.unfixTopic", parameters);
        }
    }
}