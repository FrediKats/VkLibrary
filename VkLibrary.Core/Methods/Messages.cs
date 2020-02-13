using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VkApi.Wrapper.Responses.Messages;
using VkApi.Wrapper.Types.Base;
using VkApi.Wrapper.Types.Messages;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Methods
{
    public class Messages
    {
        private readonly Vkontakte _vkontakte;

        internal Messages(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Adds a new user to a chat.
        ///</summary>
        public Task<BaseOkResponse> AddChatUser(int? chatId = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("messages.addChatUser", parameters);
        }

        ///<summary>
        /// Allows sending messages from community to the current user.
        ///</summary>
        public Task<BaseOkResponse> AllowMessagesFromGroup(int? groupId = null, String key = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (key != null)
                parameters.Add("key", key.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("messages.allowMessagesFromGroup", parameters);
        }

        ///<summary>
        /// Creates a chat with several participants.
        ///</summary>
        public Task<int> CreateChat(int[] userIds = null, String title = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            return _vkontakte.RequestAsync<int>("messages.createChat", parameters);
        }

        ///<summary>
        /// Deletes a chat's cover picture.
        ///</summary>
        public Task<MessagesDeleteChatPhotoResponse> DeleteChatPhoto(int? chatId = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<MessagesDeleteChatPhotoResponse>("messages.deleteChatPhoto", parameters);
        }

        ///<summary>
        /// Deletes all private messages in a conversation.
        ///</summary>
        public Task<MessagesDeleteConversationResponse> DeleteConversation(int? userId = null, int? peerId = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<MessagesDeleteConversationResponse>("messages.deleteConversation", parameters);
        }

        ///<summary>
        /// Denies sending message from community to the current user.
        ///</summary>
        public Task<BaseOkResponse> DenyMessagesFromGroup(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("messages.denyMessagesFromGroup", parameters);
        }

        ///<summary>
        /// Edits the message.
        ///</summary>
        public Task<int> Edit(int? peerId = null, String message = null, int? messageId = null, double? lat = null, double? _long = null, String attachment = null, Boolean? keepForwardMessages = null, Boolean? keepSnippets = null, int? groupId = null, Boolean? dontParseLinks = null)
        {
            var parameters = new Dictionary<string, string>();
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (messageId != null)
                parameters.Add("message_id", messageId.ToApiString());
            if (lat != null)
                parameters.Add("lat", lat.ToApiString());
            if (_long != null)
                parameters.Add("long", _long.ToApiString());
            if (attachment != null)
                parameters.Add("attachment", attachment.ToApiString());
            if (keepForwardMessages != null)
                parameters.Add("keep_forward_messages", keepForwardMessages.ToApiString());
            if (keepSnippets != null)
                parameters.Add("keep_snippets", keepSnippets.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (dontParseLinks != null)
                parameters.Add("dont_parse_links", dontParseLinks.ToApiString());
            return _vkontakte.RequestAsync<int>("messages.edit", parameters);
        }

        ///<summary>
        /// Edits the title of a chat.
        ///</summary>
        public Task<BaseOkResponse> EditChat(int? chatId = null, String title = null)
        {
            var parameters = new Dictionary<string, string>();
            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("messages.editChat", parameters);
        }

        ///<summary>
        /// Returns messages by their IDs within the conversation.
        ///</summary>
        public Task<MessagesGetByConversationMessageIdResponse> GetByConversationMessageId(int? peerId = null, int[] conversationMessageIds = null, Boolean? extended = null, UsersFields[] fields = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (conversationMessageIds != null)
                parameters.Add("conversation_message_ids", conversationMessageIds.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<MessagesGetByConversationMessageIdResponse>("messages.getByConversationMessageId", parameters);
        }

        ///<summary>
        /// Returns messages by their IDs.
        ///</summary>
        public Task<MessagesGetByIdResponse> GetById(int[] messageIds = null, int? previewLength = null, Boolean? extended = null, UsersFields[] fields = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (messageIds != null)
                parameters.Add("message_ids", messageIds.ToApiString());
            if (previewLength != null)
                parameters.Add("preview_length", previewLength.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<MessagesGetByIdResponse>("messages.getById", parameters);
        }

        ///<summary>
        /// Returns a list of IDs of users participating in a chat.
        ///</summary>
        public Task<MessagesGetConversationMembersResponse> GetConversationMembers(int? peerId = null, UsersFields[] fields = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<MessagesGetConversationMembersResponse>("messages.getConversationMembers", parameters);
        }

        ///<summary>
        /// Returns a list of the current user's conversations.
        ///</summary>
        public Task<MessagesGetConversationsResponse> GetConversations(int? offset = null, int? count = null, String filter = null, Boolean? extended = null, int? startMessageId = null, BaseUserGroupFields[] fields = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (filter != null)
                parameters.Add("filter", filter.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (startMessageId != null)
                parameters.Add("start_message_id", startMessageId.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<MessagesGetConversationsResponse>("messages.getConversations", parameters);
        }

        ///<summary>
        /// Returns conversations by their IDs
        ///</summary>
        public Task<MessagesGetConversationsByIdResponse> GetConversationsById(int[] peerIds = null, Boolean? extended = null, BaseUserGroupFields[] fields = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (peerIds != null)
                parameters.Add("peer_ids", peerIds.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<MessagesGetConversationsByIdResponse>("messages.getConversationsById", parameters);
        }

        ///<summary>
        /// Returns message history for the specified user or group chat.
        ///</summary>
        public Task<MessagesGetHistoryResponse> GetHistory(int? offset = null, int? count = null, int? userId = null, int? peerId = null, int? startMessageId = null, int? rev = null, Boolean? extended = null, UsersFields[] fields = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (startMessageId != null)
                parameters.Add("start_message_id", startMessageId.ToApiString());
            if (rev != null)
                parameters.Add("rev", rev.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<MessagesGetHistoryResponse>("messages.getHistory", parameters);
        }

        ///<summary>
        /// Returns media files from the dialog or group chat.
        ///</summary>
        public Task<MessagesGetHistoryAttachmentsResponse> GetHistoryAttachments(int? peerId = null, String mediaType = null, String startFrom = null, int? count = null, Boolean? photoSizes = null, UsersFields[] fields = null, int? groupId = null, Boolean? preserveOrder = null, int? maxForwardsLevel = null)
        {
            var parameters = new Dictionary<string, string>();
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (mediaType != null)
                parameters.Add("media_type", mediaType.ToApiString());
            if (startFrom != null)
                parameters.Add("start_from", startFrom.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (photoSizes != null)
                parameters.Add("photo_sizes", photoSizes.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (preserveOrder != null)
                parameters.Add("preserve_order", preserveOrder.ToApiString());
            if (maxForwardsLevel != null)
                parameters.Add("max_forwards_level", maxForwardsLevel.ToApiString());
            return _vkontakte.RequestAsync<MessagesGetHistoryAttachmentsResponse>("messages.getHistoryAttachments", parameters);
        }

        ///<summary>
        /// Returns a user's current status and date of last activity.
        ///</summary>
        public Task<MessagesLastActivity> GetLastActivity(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            return _vkontakte.RequestAsync<MessagesLastActivity>("messages.getLastActivity", parameters);
        }

        ///<summary>
        /// Returns updates in user's private messages.
        ///</summary>
        public Task<MessagesGetLongPollHistoryResponse> GetLongPollHistory(int? ts = null, int? pts = null, int? previewLength = null, Boolean? onlines = null, UsersFields[] fields = null, int? eventsLimit = null, int? msgsLimit = null, int? maxMsgId = null, int? groupId = null, int? lpVersion = null, int? lastN = null, Boolean? credentials = null)
        {
            var parameters = new Dictionary<string, string>();
            if (ts != null)
                parameters.Add("ts", ts.ToApiString());
            if (pts != null)
                parameters.Add("pts", pts.ToApiString());
            if (previewLength != null)
                parameters.Add("preview_length", previewLength.ToApiString());
            if (onlines != null)
                parameters.Add("onlines", onlines.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (eventsLimit != null)
                parameters.Add("events_limit", eventsLimit.ToApiString());
            if (msgsLimit != null)
                parameters.Add("msgs_limit", msgsLimit.ToApiString());
            if (maxMsgId != null)
                parameters.Add("max_msg_id", maxMsgId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (lpVersion != null)
                parameters.Add("lp_version", lpVersion.ToApiString());
            if (lastN != null)
                parameters.Add("last_n", lastN.ToApiString());
            if (credentials != null)
                parameters.Add("credentials", credentials.ToApiString());
            return _vkontakte.RequestAsync<MessagesGetLongPollHistoryResponse>("messages.getLongPollHistory", parameters);
        }

        ///<summary>
        /// Returns data required for connection to a Long Poll server.
        ///</summary>
        public Task<MessagesLongpollParams> GetLongPollServer(Boolean? needPts = null, int? groupId = null, int? lpVersion = null)
        {
            var parameters = new Dictionary<string, string>();
            if (needPts != null)
                parameters.Add("need_pts", needPts.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (lpVersion != null)
                parameters.Add("lp_version", lpVersion.ToApiString());
            return _vkontakte.RequestAsync<MessagesLongpollParams>("messages.getLongPollServer", parameters);
        }

        ///<summary>
        /// Returns information whether sending messages from the community to current user is allowed.
        ///</summary>
        public Task<MessagesIsMessagesFromGroupAllowedResponse> IsMessagesFromGroupAllowed(int? groupId = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            return _vkontakte.RequestAsync<MessagesIsMessagesFromGroupAllowedResponse>("messages.isMessagesFromGroupAllowed", parameters);
        }

        ///<summary>
        /// Marks and unmarks conversations as unanswered.
        ///</summary>
        public Task<BaseOkResponse> MarkAsAnsweredConversation(int? peerId = null, Boolean? answered = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (answered != null)
                parameters.Add("answered", answered.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("messages.markAsAnsweredConversation", parameters);
        }

        ///<summary>
        /// Marks and unmarks messages as important (starred).
        ///</summary>
        public Task<int[]> MarkAsImportant(int[] messageIds = null, int? important = null)
        {
            var parameters = new Dictionary<string, string>();
            if (messageIds != null)
                parameters.Add("message_ids", messageIds.ToApiString());
            if (important != null)
                parameters.Add("important", important.ToApiString());
            return _vkontakte.RequestAsync<int[]>("messages.markAsImportant", parameters);
        }

        ///<summary>
        /// Marks and unmarks conversations as important.
        ///</summary>
        public Task<BaseOkResponse> MarkAsImportantConversation(int? peerId = null, Boolean? important = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (important != null)
                parameters.Add("important", important.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("messages.markAsImportantConversation", parameters);
        }

        ///<summary>
        /// Marks messages as read.
        ///</summary>
        public Task<BaseOkResponse> MarkAsRead(int[] messageIds = null, int? peerId = null, int? startMessageId = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (messageIds != null)
                parameters.Add("message_ids", messageIds.ToApiString());
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (startMessageId != null)
                parameters.Add("start_message_id", startMessageId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("messages.markAsRead", parameters);
        }

        ///<summary>
        /// Pin a message.
        ///</summary>
        public Task<MessagesPinnedMessage> Pin(int? peerId = null, int? messageId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (messageId != null)
                parameters.Add("message_id", messageId.ToApiString());
            return _vkontakte.RequestAsync<MessagesPinnedMessage>("messages.pin", parameters);
        }

        ///<summary>
        /// Allows the current user to leave a chat or, if the current user started the chat, allows the user to remove another user from the chat.
        ///</summary>
        public Task<BaseOkResponse> RemoveChatUser(int? chatId = null, int? userId = null, int? memberId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (memberId != null)
                parameters.Add("member_id", memberId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("messages.removeChatUser", parameters);
        }

        ///<summary>
        /// Restores a deleted message.
        ///</summary>
        public Task<BaseOkResponse> Restore(int? messageId = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (messageId != null)
                parameters.Add("message_id", messageId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("messages.restore", parameters);
        }

        ///<summary>
        /// Returns a list of the current user's private messages that match search criteria.
        ///</summary>
        public Task<MessagesSearchResponse> Search(String q = null, int? peerId = null, int? date = null, int? previewLength = null, int? offset = null, int? count = null, Boolean? extended = null, String[] fields = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (date != null)
                parameters.Add("date", date.ToApiString());
            if (previewLength != null)
                parameters.Add("preview_length", previewLength.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<MessagesSearchResponse>("messages.search", parameters);
        }

        ///<summary>
        /// Returns a list of the current user's conversations that match search criteria.
        ///</summary>
        public Task<MessagesSearchConversationsResponse> SearchConversations(String q = null, int? count = null, Boolean? extended = null, UsersFields[] fields = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<MessagesSearchConversationsResponse>("messages.searchConversations", parameters);
        }

        ///<summary>
        /// Sends a message.
        ///</summary>
        public Task<int> Send(int? userId = null, int? randomId = null, int? peerId = null, String domain = null, int? chatId = null, int[] userIds = null, String message = null, double? lat = null, double? _long = null, String attachment = null, int? replyTo = null, int[] forwardMessages = null, String forward = null, int? stickerId = null, int? groupId = null, String keyboard = null, String payload = null, Boolean? dontParseLinks = null, Boolean? disableMentions = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (randomId != null)
                parameters.Add("random_id", randomId.ToApiString());
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (domain != null)
                parameters.Add("domain", domain.ToApiString());
            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (message != null)
                parameters.Add("message", message.ToApiString());
            if (lat != null)
                parameters.Add("lat", lat.ToApiString());
            if (_long != null)
                parameters.Add("long", _long.ToApiString());
            if (attachment != null)
                parameters.Add("attachment", attachment.ToApiString());
            if (replyTo != null)
                parameters.Add("reply_to", replyTo.ToApiString());
            if (forwardMessages != null)
                parameters.Add("forward_messages", forwardMessages.ToApiString());
            if (forward != null)
                parameters.Add("forward", forward.ToApiString());
            if (stickerId != null)
                parameters.Add("sticker_id", stickerId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (keyboard != null)
                parameters.Add("keyboard", keyboard.ToApiString());
            if (payload != null)
                parameters.Add("payload", payload.ToApiString());
            if (dontParseLinks != null)
                parameters.Add("dont_parse_links", dontParseLinks.ToApiString());
            if (disableMentions != null)
                parameters.Add("disable_mentions", disableMentions.ToApiString());
            return _vkontakte.RequestAsync<int>("messages.send", parameters);
        }

        ///<summary>
        /// Changes the status of a user as typing in a conversation.
        ///</summary>
        public Task<BaseOkResponse> SetActivity(int? userId = null, String type = null, int? peerId = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (type != null)
                parameters.Add("type", type.ToApiString());
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("messages.setActivity", parameters);
        }

        ///<summary>
        /// Sets a previously-uploaded picture as the cover picture of a chat.
        ///</summary>
        public Task<MessagesSetChatPhotoResponse> SetChatPhoto(String file = null)
        {
            var parameters = new Dictionary<string, string>();
            if (file != null)
                parameters.Add("file", file.ToApiString());
            return _vkontakte.RequestAsync<MessagesSetChatPhotoResponse>("messages.setChatPhoto", parameters);
        }
    }
}