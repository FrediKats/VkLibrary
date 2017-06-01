using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using VkLib.Responses.Messages;
using VkLib.Types.Messages;

namespace VkLib.Methods
{
    /// <summary>
    ///     Messages API section.
    /// </summary>
    public class Messages
    {
        private readonly Vkontakte _vkontakte;

        internal Messages(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        ///     Returns a list of the current user's incoming or outgoing private messages.
        ///     Docs: <see href="https://vk.com/dev/messages.get">messages.get</see>
        /// </summary>
        /// <param name="out_">'1' — to return outgoing messages; '0' — to return incoming messages (default)</param>
        /// <param name="offset">Offset needed to return a specific subset of messages.</param>
        /// <param name="count">Number of messages to return.</param>
        /// <param name="timeOffset">
        ///     Maximum time since a message was sent, in seconds. To return messages without a time
        ///     limitation, set as '0'.
        /// </param>
        /// <param name="previewLength">
        ///     Number of characters after which to truncate a previewed message. To preview the full
        ///     message, specify '0'.; "NOTE: Messages are not truncated by default. Messages are truncated by words."
        /// </param>
        /// <param name="lastMessageId">
        ///     ID of the message received before the message that will be returned last (provided that
        ///     no more than 'count' messages were received before it; otherwise 'offset' parameter shall be used).
        /// </param>
        public async Task<ApiItemsResponse<Message>> Get(bool? out_ = null, int? offset = null, int? count = null,
            int? timeOffset = null, int? previewLength = null, int? lastMessageId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (out_ != null)
                parameters.Add("out_", out_.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (timeOffset != null)
                parameters.Add("time_offset", timeOffset.ToApiString());
            if (previewLength != null)
                parameters.Add("preview_length", previewLength.ToApiString());
            if (lastMessageId != null)
                parameters.Add("last_message_id", lastMessageId.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<Message>>("messages.get", parameters);
        }

        /// <summary>
        ///     Returns a list of the current user's conversations.
        ///     Docs: <see href="https://vk.com/dev/messages.getDialogs">messages.getDialogs</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of messages.</param>
        /// <param name="count">Number of messages to return.</param>
        /// <param name="startMessageId">ID of the message from what to return dialogs.</param>
        /// <param name="previewLength">
        ///     Number of characters after which to truncate a previewed message. To preview the full
        ///     message, specify '0'.; "NOTE: Messages are not truncated by default. Messages are truncated by words."
        /// </param>
        /// <param name="unread">'1' — return unread messages only.</param>
        public async Task<ApiItemsResponse<Dialog>> GetDialogs(int? offset = null, int? count = null,
            int? startMessageId = null, int? previewLength = null, bool? unread = null)
        {
            var parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (startMessageId != null)
                parameters.Add("start_message_id", startMessageId.ToApiString());
            if (previewLength != null)
                parameters.Add("preview_length", previewLength.ToApiString());
            if (unread != null)
                parameters.Add("unread", unread.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<Dialog>>("messages.getDialogs", parameters);
        }

        /// <summary>
        ///     Returns messages by their IDs.
        ///     Docs: <see href="https://vk.com/dev/messages.getById">messages.getById</see>
        /// </summary>
        /// <param name="messageIds">Message IDs.</param>
        public async Task<ApiItemsResponse<Message>> GetById(IEnumerable<int?> messageIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (messageIds != null)
                parameters.Add("message_ids", messageIds.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<Message>>("messages.getById", parameters);
        }

        /// <summary>
        ///     Returns a list of the current user's private messages that match search criteria.
        ///     Docs: <see href="https://vk.com/dev/messages.search">messages.search</see>
        /// </summary>
        /// <param name="q">Search query string.</param>
        /// <param name="peerId">
        ///     Destination ID.; ; "For user:; 'User ID', e.g. '12345'.; ; For chat:; '2000000000' + 'chat_id',
        ///     e.g. '2000000001'.; ; For community:; '- community ID', e.g. '-12345'.; "
        /// </param>
        /// <param name="date">Date to search message before in Unixtime.</param>
        /// <param name="count">Number of messages to return.</param>
        public async Task<ApiItemsResponse<Message>> Search(string q = null, int? peerId = null, int? date = null,
            int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (date != null)
                parameters.Add("date", date.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<Message>>("messages.search", parameters);
        }

        /// <summary>
        ///     Returns message history for the specified user or group chat.
        ///     Docs: <see href="https://vk.com/dev/messages.getHistory">messages.getHistory</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of messages.</param>
        /// <param name="count">Number of messages to return.</param>
        /// <param name="userId">ID of the user whose message history you want to return.</param>
        /// <param name="peerId"></param>
        /// <param name="startMessageId">Starting message ID from which to return history.</param>
        /// <param name="rev">
        ///     Sort order:; '1' — return messages in chronological order.; '0' — return messages in reverse
        ///     chronological order.
        /// </param>
        public async Task<ApiItemsResponse<Message>> GetHistory(int? offset = null, int? count = null,
            int? userId = null, int? peerId = null, int? startMessageId = null, int? rev = null)
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

            return await _vkontakte.GetAsync<ApiItemsResponse<Message>>("messages.getHistory", parameters);
        }

        /// <summary>
        ///     Returns media files from the dialog or group chat.
        ///     Docs: <see href="https://vk.com/dev/messages.getHistoryAttachments">messages.getHistoryAttachments</see>
        /// </summary>
        /// <param name="peerId">Peer ID.; ; "; For group chat:; '2000000000 + chat ID' ; ; For community:; '-community ID'"</param>
        /// <param name="mediaType">
        ///     Type of media files to return:; *'photo';; *'video';; *'audio';; *'doc';;
        ///     *'link'.;;*'market'.;;*'wall'.;;*'share'
        /// </param>
        /// <param name="startFrom">Message ID to start return results from.</param>
        /// <param name="count">Number of objects to return.</param>
        /// <param name="photoSizes">'1' — to return photo sizes in a</param>
        /// <param name="fields">Additional profile [vk.com/dev/fields|fields] to return. </param>
        public async Task<ApiItemsResponse<AttachmentsContainer>> GetHistoryAttachments(int? peerId = null,
            string mediaType = null, string startFrom = null, int? count = null, bool? photoSizes = null,
            IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (mediaType != null)
                parameters.Add("media_type", mediaType);
            if (startFrom != null)
                parameters.Add("start_from", startFrom);
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (photoSizes != null)
                parameters.Add("photo_sizes", photoSizes.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<AttachmentsContainer>>("messages.getHistoryAttachments",
                parameters);
        }

        /// <summary>
        ///     Sends a message.
        ///     Docs: <see href="https://vk.com/dev/messages.send">messages.send</see>
        /// </summary>
        /// <param name="userId">User ID (by default — current user).</param>
        /// <param name="randomId">Unique identifier to avoid resending the message.</param>
        /// <param name="peerId">
        ///     Destination ID.; ; "For user:; 'User ID', e.g. '12345'.; ; For chat:; '2000000000' + 'chat_id',
        ///     e.g. '2000000001'.; ; For community:; '- community ID', e.g. '-12345'.; "
        /// </param>
        /// <param name="domain">User's short address (for example, 'illarionov').</param>
        /// <param name="chatId">ID of conversation the message will relate to.</param>
        /// <param name="userIds">IDs of message recipients (if new conversation shall be started).</param>
        /// <param name="message">(Required if 'attachments' is not set.) Text of the message.</param>
        /// <param name="lat">Geographical latitude of a check-in, in degrees (from -90 to 90).</param>
        /// <param name="long_">Geographical longitude of a check-in, in degrees (from -180 to 180).</param>
        /// <param name="attachment">
        ///     (Required if 'message' is not set.) List of objects attached to the message, separated by commas, in the following
        ///     format:; "%owner_id%_%media_id%"; '' — Type of media attachment:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' —
        ///     document; 'wall' — wall post; '%owner_id%' — ID of the media attachment owner.; '%media_id%' — media attachment ID.; ; Example:; "photo100172_166443618"
        /// </param>
        /// <param name="forwardMessages">
        ///     ID of forwarded messages, separated with a comma. Listed messages of the sender will be
        ///     shown in the message body at the recipient's.; ; Example:; "123,431,544"
        /// </param>
        /// <param name="stickerId">Sticker id.</param>
        /// <param name="notification">'1' if the message is a notification (for community messages).</param>
        public async Task<int?> Send(int? userId = null, int? randomId = null, int? peerId = null,
            string domain = null, int? chatId = null, IEnumerable<int?> userIds = null, string message = null,
            uint? lat = null, uint? long_ = null, string attachment = null, string forwardMessages = null,
            int? stickerId = null, bool? notification = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (randomId != null)
                parameters.Add("random_id", randomId.ToApiString());
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (domain != null)
                parameters.Add("domain", domain);
            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());
            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (message != null)
                parameters.Add("message", message);
            if (lat != null)
                parameters.Add("lat", lat.ToApiString());
            if (long_ != null)
                parameters.Add("long_", long_.ToApiString());
            if (attachment != null)
                parameters.Add("attachment", attachment);
            if (forwardMessages != null)
                parameters.Add("forward_messages", forwardMessages);
            if (stickerId != null)
                parameters.Add("sticker_id", stickerId.ToApiString());
            if (notification != null)
                parameters.Add("notification", notification.ToApiString());

            return await _vkontakte.GetAsync<int?>("messages.send", parameters);
        }

        /// <summary>
        ///     Deletes one or more messages.
        ///     Docs: <see href="https://vk.com/dev/messages.delete">messages.delete</see>
        /// </summary>
        /// <param name="messageIds">Message IDs.</param>
        /// <param name="spam">'1' — to mark message as spam.</param>
        public async Task<JToken> Delete(IEnumerable<int?> messageIds = null, bool? spam = null)
        {
            var parameters = new Dictionary<string, string>();

            if (messageIds != null)
                parameters.Add("message_ids", messageIds.ToApiString());
            if (spam != null)
                parameters.Add("spam", spam.ToApiString());

            return await _vkontakte.GetAsync<JToken>("messages.delete", parameters);
        }

        /// <summary>
        ///     Deletes all private messages in a conversation.
        ///     Docs: <see href="https://vk.com/dev/messages.deleteDialog">messages.deleteDialog</see>
        /// </summary>
        /// <param name="userId">User ID. To clear a chat history use 'chat_id'</param>
        /// <param name="peerId">
        ///     Destination ID.; ; "For user:; 'User ID', e.g. '12345'.; ; For chat:; '2000000000' + 'chat_id',
        ///     e.g. '2000000001'.; ; For community:; '- community ID', e.g. '-12345'.; "
        /// </param>
        /// <param name="offset">Offset needed to return a specific subset of messages.</param>
        /// <param name="count">
        ///     Number of messages to delete.; "NOTE: If the number of messages exceeds the maximum, the method
        ///     shall be called several times."
        /// </param>
        public async Task<int> DeleteDialog(string userId = null, int? peerId = null, int? offset = null,
            int? count = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId);
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());

            return await _vkontakte.GetAsync<int>("messages.deleteDialog", parameters);
        }

        /// <summary>
        ///     Restores a deleted message.
        ///     Docs: <see href="https://vk.com/dev/messages.restore">messages.restore</see>
        /// </summary>
        /// <param name="messageId">ID of a previously-deleted message to restore.</param>
        public async Task<int> Restore(int? messageId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (messageId != null)
                parameters.Add("message_id", messageId.ToApiString());

            return await _vkontakte.GetAsync<int>("messages.restore", parameters);
        }

        /// <summary>
        ///     Marks messages as read.
        ///     Docs: <see href="https://vk.com/dev/messages.markAsRead">messages.markAsRead</see>
        /// </summary>
        /// <param name="messageIds">IDs of messages to mark as read.</param>
        /// <param name="peerId">
        ///     Destination ID.; ; "For user:; 'User ID', e.g. '12345'.; ; For chat:; '2000000000' + 'chat_id',
        ///     e.g. '2000000001'.; ; For community:; '- community ID', e.g. '-12345'.; "
        /// </param>
        /// <param name="startMessageId">Message ID to start from.</param>
        public async Task<int> MarkAsRead(IEnumerable<int?> messageIds = null, string peerId = null,
            int? startMessageId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (messageIds != null)
                parameters.Add("message_ids", messageIds.ToApiString());
            if (peerId != null)
                parameters.Add("peer_id", peerId);
            if (startMessageId != null)
                parameters.Add("start_message_id", startMessageId.ToApiString());

            return await _vkontakte.GetAsync<int>("messages.markAsRead", parameters);
        }

        /// <summary>
        ///     Marks and unmarks messages as important (starred).
        ///     Docs: <see href="https://vk.com/dev/messages.markAsImportant">messages.markAsImportant</see>
        /// </summary>
        /// <param name="messageIds">IDs of messages to mark as important.</param>
        /// <param name="important">'1' — to add a star (mark as important); '0' — to remove the star</param>
        public async Task<IEnumerable<int?>> MarkAsImportant(IEnumerable<int?> messageIds = null,
            int? important = null)
        {
            var parameters = new Dictionary<string, string>();

            if (messageIds != null)
                parameters.Add("message_ids", messageIds.ToApiString());
            if (important != null)
                parameters.Add("important", important.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<int?>>("messages.markAsImportant", parameters);
        }

        /// <summary>
        ///     Returns data required for connection to a Long Poll server.
        ///     Docs: <see href="https://vk.com/dev/messages.getLongPollServer">messages.getLongPollServer</see>
        /// </summary>
        /// <param name="useSsl">'1' — to use SSL.</param>
        /// <param name="needPts">
        ///     '1' — to return the 'pts' field, needed for the
        ///     [vk.com/dev/messages.getLongPollHistory|messages.getLongPollHistory] method.
        /// </param>
        public async Task<LongpollParams> GetLongPollServer(bool? useSsl = null, bool? needPts = null)
        {
            var parameters = new Dictionary<string, string>();

            if (useSsl != null)
                parameters.Add("use_ssl", useSsl.ToApiString());
            if (needPts != null)
                parameters.Add("need_pts", needPts.ToApiString());

            return await _vkontakte.GetAsync<LongpollParams>("messages.getLongPollServer", parameters);
        }

        /// <summary>
        ///     Returns updates in user's private messages.
        ///     Docs: <see href="https://vk.com/dev/messages.getLongPollHistory">messages.getLongPollHistory</see>
        /// </summary>
        /// <param name="ts">
        ///     Last value of the 'ts' parameter returned from the Long Poll server or by using
        ///     [vk.com/dev/messages.getLongPollHistory|messages.getLongPollHistory] method.
        /// </param>
        /// <param name="pts">
        ///     Lsat value of 'pts' parameter returned from the Long Poll server or by using
        ///     [vk.com/dev/messages.getLongPollHistory|messages.getLongPollHistory] method.
        /// </param>
        /// <param name="previewLength">
        ///     Number of characters after which to truncate a previewed message. To preview the full
        ///     message, specify '0'.; "NOTE: Messages are not truncated by default. Messages are truncated by words."
        /// </param>
        /// <param name="onlines">'1' — to return history with online users only.</param>
        /// <param name="fields">Additional profile [vk.com/dev/fields|fields] to return.</param>
        /// <param name="eventsLimit">Maximum number of events to return.</param>
        /// <param name="msgsLimit">Maximum number of messages to return.</param>
        /// <param name="maxMsgId">
        ///     Maximum ID of the message among existing ones in the local copy. Both messages received with
        ///     API methods (for example, , ), and data received from a Long Poll server (events with code 4) are taken into
        ///     account.
        /// </param>
        public async Task<GetLongPollHistoryResponse> GetLongPollHistory(int? ts = null, int? pts = null,
            int? previewLength = null, bool? onlines = null, IEnumerable<string> fields = null,
            int? eventsLimit = null, int? msgsLimit = null, int? maxMsgId = null)
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

            return await _vkontakte.GetAsync<GetLongPollHistoryResponse>("messages.getLongPollHistory", parameters);
        }

        /// <summary>
        ///     Returns information about a chat.
        ///     Docs: <see href="https://vk.com/dev/messages.getChat">messages.getChat</see>
        /// </summary>
        /// <param name="chatId">Chat ID.</param>
        /// <param name="chatIds">Chat IDs.</param>
        /// <param name="fields">Profile fields to return.;</param>
        /// <param name="nameCase">
        ///     Case for declension of user name and surname:; 'nom' — nominative (default); 'gen' — genitive ;
        ///     'dat' — dative; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional
        /// </param>
        public async Task<Chat> GetChat(int? chatId = null, IEnumerable<int?> chatIds = null,
            IEnumerable<string> fields = null, string nameCase = null)
        {
            var parameters = new Dictionary<string, string>();

            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());
            if (chatIds != null)
                parameters.Add("chat_ids", chatIds.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase);

            return await _vkontakte.GetAsync<Chat>("messages.getChat", parameters);
        }

        /// <summary>
        ///     Creates a chat with several participants.
        ///     Docs: <see href="https://vk.com/dev/messages.createChat">messages.createChat</see>
        /// </summary>
        /// <param name="userIds">IDs of the users to be added to the chat.</param>
        /// <param name="title">Chat title.</param>
        public async Task<int?> CreateChat(IEnumerable<int?> userIds = null, string title = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userIds != null)
                parameters.Add("user_ids", userIds.ToApiString());
            if (title != null)
                parameters.Add("title", title);

            return await _vkontakte.GetAsync<int?>("messages.createChat", parameters);
        }

        /// <summary>
        ///     Edits the title of a chat.
        ///     Docs: <see href="https://vk.com/dev/messages.editChat">messages.editChat</see>
        /// </summary>
        /// <param name="chatId">Chat ID.</param>
        /// <param name="title">New title of the chat.</param>
        public async Task<int> EditChat(int? chatId = null, string title = null)
        {
            var parameters = new Dictionary<string, string>();

            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());
            if (title != null)
                parameters.Add("title", title);

            return await _vkontakte.GetAsync<int>("messages.editChat", parameters);
        }

        /// <summary>
        ///     Returns a list of IDs of users participating in a chat.
        ///     Docs: <see href="https://vk.com/dev/messages.getChatUsers">messages.getChatUsers</see>
        /// </summary>
        /// <param name="chatId">Chat ID.</param>
        /// <param name="chatIds">Chat IDs.</param>
        /// <param name="fields">Profile fields to return.;</param>
        /// <param name="nameCase">
        ///     Case for declension of user name and surname:; 'nom' — nominative (default); 'gen' — genitive;
        ///     'dat' — dative; 'acc' — accusative; 'ins' — instrumental; 'abl' — prepositional
        /// </param>
        public async Task<IEnumerable<int?>> GetChatUsers(int? chatId = null, IEnumerable<int?> chatIds = null,
            IEnumerable<string> fields = null, string nameCase = null)
        {
            var parameters = new Dictionary<string, string>();

            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());
            if (chatIds != null)
                parameters.Add("chat_ids", chatIds.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            if (nameCase != null)
                parameters.Add("name_case", nameCase);

            return await _vkontakte.GetAsync<IEnumerable<int?>>("messages.getChatUsers", parameters);
        }

        /// <summary>
        ///     Changes the status of a user as typing in a conversation.
        ///     Docs: <see href="https://vk.com/dev/messages.setActivity">messages.setActivity</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="type">'typing' — user has started to type.</param>
        /// <param name="peerId">
        ///     Destination ID.; ; "For user:; 'User ID', e.g. '12345'.; ; For chat:; '2000000000' + 'chat_id',
        ///     e.g. '2000000001'.; ; For community:; '- community ID', e.g. '-12345'.; "
        /// </param>
        public async Task<int> SetActivity(string userId = null, string type = null, int? peerId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId);
            if (type != null)
                parameters.Add("type", type);
            if (peerId != null)
                parameters.Add("peer_id", peerId.ToApiString());

            return await _vkontakte.GetAsync<int>("messages.setActivity", parameters);
        }

        /// <summary>
        ///     Returns a list of the current user's conversations that match search criteria.
        ///     Docs: <see href="https://vk.com/dev/messages.searchDialogs">messages.searchDialogs</see>
        /// </summary>
        /// <param name="q">Search query string.</param>
        /// <param name="limit">Maximum number of results.</param>
        /// <param name="fields">Profile fields to return.;</param>
        public async Task<IEnumerable<object>> SearchDialogs(string q = null, int? limit = null,
            IEnumerable<string> fields = null)
        {
            var parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (limit != null)
                parameters.Add("limit", limit.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<object>>("messages.searchDialogs", parameters);
        }

        /// <summary>
        ///     Adds a new user to a chat.
        ///     Docs: <see href="https://vk.com/dev/messages.addChatUser">messages.addChatUser</see>
        /// </summary>
        /// <param name="chatId">Chat ID.</param>
        /// <param name="userId">ID of the user to be added to the chat.</param>
        public async Task<int> AddChatUser(int? chatId = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<int>("messages.addChatUser", parameters);
        }

        /// <summary>
        ///     Allows the current user to leave a chat or, if the current user started the chat, allows the user to remove another
        ///     user from the chat.
        ///     Docs: <see href="https://vk.com/dev/messages.removeChatUser">messages.removeChatUser</see>
        /// </summary>
        /// <param name="chatId">Chat ID.</param>
        /// <param name="userId">ID of the user to be removed from the chat.</param>
        public async Task<int> RemoveChatUser(int? chatId = null, string userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId);

            return await _vkontakte.GetAsync<int>("messages.removeChatUser", parameters);
        }

        /// <summary>
        ///     Returns a user's current status and date of last activity.
        ///     Docs: <see href="https://vk.com/dev/messages.getLastActivity">messages.getLastActivity</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        public async Task<LastActivity> GetLastActivity(int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<LastActivity>("messages.getLastActivity", parameters);
        }

        /// <summary>
        ///     Sets a previously-uploaded picture as the cover picture of a chat.
        ///     Docs: <see href="https://vk.com/dev/messages.setChatPhoto">messages.setChatPhoto</see>
        /// </summary>
        /// <param name="file">
        ///     Upload URL from the 'response' field returned by the
        ///     [vk.com/dev/photos.getChatUploadServer|photos.getChatUploadServer] method upon successfully uploading an image.
        /// </param>
        public async Task<SetChatPhotoResponse> SetChatPhoto(string file = null)
        {
            var parameters = new Dictionary<string, string>();

            if (file != null)
                parameters.Add("file", file);

            return await _vkontakte.GetAsync<SetChatPhotoResponse>("messages.setChatPhoto", parameters);
        }

        /// <summary>
        ///     Deletes a chat's cover picture.
        ///     Docs: <see href="https://vk.com/dev/messages.deleteChatPhoto">messages.deleteChatPhoto</see>
        /// </summary>
        /// <param name="chatId">Chat ID.</param>
        public async Task<DeleteChatPhotoResponse> DeleteChatPhoto(int? chatId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (chatId != null)
                parameters.Add("chat_id", chatId.ToApiString());

            return await _vkontakte.GetAsync<DeleteChatPhotoResponse>("messages.deleteChatPhoto", parameters);
        }

        /// <summary>
        ///     Denies sending message from community to the current user.
        ///     Docs: <see href="https://vk.com/dev/messages.denyMessagesFromCommunity">messages.denyMessagesFromCommunity</see>
        /// </summary>
        /// <param name="groupId">Group ID.</param>
        public async Task<int> DenyMessagesFromCommunity(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return await _vkontakte.GetAsync<int>("messages.denyMessagesFromCommunity", parameters);
        }

        /// <summary>
        ///     Allows sending messages from community to the current user.
        ///     Docs: <see href="https://vk.com/dev/messages.allowMessagesFromCommunity">messages.allowMessagesFromCommunity</see>
        /// </summary>
        /// <param name="groupId">Group ID.</param>
        public async Task<int> AllowMessagesFromCommunity(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return await _vkontakte.GetAsync<int>("messages.allowMessagesFromCommunity", parameters);
        }

        /// <summary>
        ///     Returns information whether sending messages from the community to current user is allowed.
        ///     Docs: <see href="https://vk.com/dev/messages.isMessagesFromGroupAllowed">messages.isMessagesFromGroupAllowed</see>
        /// </summary>
        /// <param name="groupId">Group ID.</param>
        /// <param name="userId">User ID.</param>
        public async Task<IsMessagesFromGroupAllowedResponse> IsMessagesFromGroupAllowed(int? groupId = null,
            int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return await _vkontakte.GetAsync<IsMessagesFromGroupAllowedResponse>("messages.isMessagesFromGroupAllowed",
                parameters);
        }
    }
}