using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Messages API section.
    /// </summary>
    public class Messages
    {
        private Vkontakte _vkontakte;

        internal Messages(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of the current user's incoming or outgoing private messages.
        /// Docs: <see href="https://vk.com/dev/messages.get">messages.get</see>
        /// </summary>
        /// <param name="out">'1' — to return outgoing messages; '0' — to return incoming messages (default)</param>
        /// <param name="offset">Offset needed to return a specific subset of messages.</param>
        /// <param name="count">Number of messages to return.</param>
        /// <param name="time_offset">Maximum time since a message was sent, in seconds. To return messages without a time limitation, set as '0'.</param>
        /// <param name="preview_length">Number of characters after which to truncate a previewed message. To preview the full message, specify '0'.; "NOTE: Messages are not truncated by default. Messages are truncated by words."</param>
        /// <param name="last_message_id">ID of the message received before the message that will be returned last (provided that no more than 'count' messages were received before it; otherwise 'offset' parameter shall be used).</param>
        public async Task<ApiItemsResponse<VkLib.Types.Messages.Message>> Get(bool? out_ = null, int? offset = null, int? count = null, int? time_offset = null, int? preview_length = null, int? last_message_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (out_ != null)
                parameters.Add("out_", out_.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (time_offset != null)
                parameters.Add("time_offset", time_offset.ToString());
            if (preview_length != null)
                parameters.Add("preview_length", preview_length.ToString());
            if (last_message_id != null)
                parameters.Add("last_message_id", last_message_id.ToString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Messages.Message>>("messages.get", parameters);
        }

        /// <summary>
        /// Returns a list of the current user's conversations.
        /// Docs: <see href="https://vk.com/dev/messages.getDialogs">messages.getDialogs</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of messages.</param>
        /// <param name="count">Number of messages to return.</param>
        /// <param name="start_message_id">ID of the message from what to return dialogs.</param>
        /// <param name="preview_length">Number of characters after which to truncate a previewed message. To preview the full message, specify '0'.; "NOTE: Messages are not truncated by default. Messages are truncated by words."</param>
        /// <param name="unread">'1' — return unread messages only.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Messages.Dialog>> GetDialogs(int? offset = null, int? count = null, int? start_message_id = null, int? preview_length = null, bool? unread = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (start_message_id != null)
                parameters.Add("start_message_id", start_message_id.ToString());
            if (preview_length != null)
                parameters.Add("preview_length", preview_length.ToString());
            if (unread != null)
                parameters.Add("unread", unread.ToString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Messages.Dialog>>("messages.getDialogs", parameters);
        }

        /// <summary>
        /// Returns messages by their IDs.
        /// Docs: <see href="https://vk.com/dev/messages.getById">messages.getById</see>
        /// </summary>
        /// <param name="message_ids">Message IDs.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Messages.Message>> GetById(IEnumerable<int?> message_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (message_ids != null)
                parameters.Add("message_ids", string.Join(",", message_ids));

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Messages.Message>>("messages.getById", parameters);
        }

        /// <summary>
        /// Returns a list of the current user's private messages that match search criteria.
        /// Docs: <see href="https://vk.com/dev/messages.search">messages.search</see>
        /// </summary>
        /// <param name="q">Search query string.</param>
        /// <param name="peer_id">Destination ID.; ; "For user:; 'User ID', e.g. '12345'.; ; For chat:; '2000000000' + 'chat_id', e.g. '2000000001'.; ; For community:; '- community ID', e.g. '-12345'.; "</param>
        /// <param name="date">Date to search message before in Unixtime.</param>
        /// <param name="count">Number of messages to return.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Messages.Message>> Search(string q = null, int? peer_id = null, int? date = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (peer_id != null)
                parameters.Add("peer_id", peer_id.ToString());
            if (date != null)
                parameters.Add("date", date.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Messages.Message>>("messages.search", parameters);
        }

        /// <summary>
        /// Returns message history for the specified user or group chat.
        /// Docs: <see href="https://vk.com/dev/messages.getHistory">messages.getHistory</see>
        /// </summary>
        /// <param name="offset">Offset needed to return a specific subset of messages.</param>
        /// <param name="count">Number of messages to return.</param>
        /// <param name="user_id">ID of the user whose message history you want to return.</param>
        /// <param name="peer_id"></param>
        /// <param name="start_message_id">Starting message ID from which to return history.</param>
        /// <param name="rev">Sort order:; '1' — return messages in chronological order.; '0' — return messages in reverse chronological order.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Messages.Message>> GetHistory(int? offset = null, int? count = null, int? user_id = null, int? peer_id = null, int? start_message_id = null, int? rev = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (peer_id != null)
                parameters.Add("peer_id", peer_id.ToString());
            if (start_message_id != null)
                parameters.Add("start_message_id", start_message_id.ToString());
            if (rev != null)
                parameters.Add("rev", rev.ToString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Messages.Message>>("messages.getHistory", parameters);
        }

        /// <summary>
        /// Returns media files from the dialog or group chat.
        /// Docs: <see href="https://vk.com/dev/messages.getHistoryAttachments">messages.getHistoryAttachments</see>
        /// </summary>
        /// <param name="peer_id">Peer ID.; ; "; For group chat:; '2000000000 + chat ID' ; ; For community:; '-community ID'"</param>
        /// <param name="media_type">Type of media files to return:; *'photo';; *'video';; *'audio';; *'doc';; *'link'.;;*'market'.;;*'wall'.;;*'share'</param>
        /// <param name="start_from">Message ID to start return results from.</param>
        /// <param name="count">Number of objects to return.</param>
        /// <param name="photo_sizes">'1' — to return photo sizes in a</param>
        /// <param name="fields">Additional profile [vk.com/dev/fields|fields] to return. </param>
        public async Task<ApiItemsResponse<VkLib.Types.Messages.AttachmentsHistory>> GetHistoryAttachments(int? peer_id = null, string media_type = null, string start_from = null, int? count = null, bool? photo_sizes = null, IEnumerable<string> fields = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (peer_id != null)
                parameters.Add("peer_id", peer_id.ToString());
            if (media_type != null)
                parameters.Add("media_type", media_type);
            if (start_from != null)
                parameters.Add("start_from", start_from);
            if (count != null)
                parameters.Add("count", count.ToString());
            if (photo_sizes != null)
                parameters.Add("photo_sizes", photo_sizes.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Messages.AttachmentsHistory>>("messages.getHistoryAttachments", parameters);
        }

        /// <summary>
        /// Sends a message.
        /// Docs: <see href="https://vk.com/dev/messages.send">messages.send</see>
        /// </summary>
        /// <param name="user_id">User ID (by default — current user).</param>
        /// <param name="random_id">Unique identifier to avoid resending the message.</param>
        /// <param name="peer_id">Destination ID.; ; "For user:; 'User ID', e.g. '12345'.; ; For chat:; '2000000000' + 'chat_id', e.g. '2000000001'.; ; For community:; '- community ID', e.g. '-12345'.; "</param>
        /// <param name="domain">User's short address (for example, 'illarionov').</param>
        /// <param name="chat_id">ID of conversation the message will relate to.</param>
        /// <param name="user_ids">IDs of message recipients (if new conversation shall be started).</param>
        /// <param name="message">(Required if 'attachments' is not set.) Text of the message.</param>
        /// <param name="lat">Geographical latitude of a check-in, in degrees (from -90 to 90).</param>
        /// <param name="long">Geographical longitude of a check-in, in degrees (from -180 to 180).</param>
        /// <param name="attachment">(Required if 'message' is not set.) List of objects attached to the message, separated by commas, in the following format:; "<owner_id>_<media_id>"; '' — Type of media attachment:; 'photo' — photo; 'video' — video; 'audio' — audio; 'doc' — document; 'wall' — wall post; '<owner_id>' — ID of the media attachment owner.; '<media_id>' — media attachment ID.; ; Example:; "photo100172_166443618"</param>
        /// <param name="forward_messages">ID of forwarded messages, separated with a comma. Listed messages of the sender will be shown in the message body at the recipient's.; ; Example:; "123,431,544"</param>
        /// <param name="sticker_id">Sticker id.</param>
        /// <param name="notification">'1' if the message is a notification (for community messages).</param>
        public async Task<int?> Send(int? user_id = null, int? random_id = null, int? peer_id = null, string domain = null, int? chat_id = null, IEnumerable<int?> user_ids = null, string message = null, uint? lat = null, uint? long_ = null, string attachment = null, string forward_messages = null, int? sticker_id = null, bool? notification = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (random_id != null)
                parameters.Add("random_id", random_id.ToString());
            if (peer_id != null)
                parameters.Add("peer_id", peer_id.ToString());
            if (domain != null)
                parameters.Add("domain", domain);
            if (chat_id != null)
                parameters.Add("chat_id", chat_id.ToString());
            if (user_ids != null)
                parameters.Add("user_ids", string.Join(",", user_ids));
            if (message != null)
                parameters.Add("message", message);
            if (lat != null)
                parameters.Add("lat", lat.ToString());
            if (long_ != null)
                parameters.Add("long_", long_.ToString());
            if (attachment != null)
                parameters.Add("attachment", attachment);
            if (forward_messages != null)
                parameters.Add("forward_messages", forward_messages);
            if (sticker_id != null)
                parameters.Add("sticker_id", sticker_id.ToString());
            if (notification != null)
                parameters.Add("notification", notification.ToString());

            return await _vkontakte.GetAsync<int?>("messages.send", parameters);
        }

        /// <summary>
        /// Deletes one or more messages.
        /// Docs: <see href="https://vk.com/dev/messages.delete">messages.delete</see>
        /// </summary>
        /// <param name="message_ids">Message IDs.</param>
        /// <param name="spam">'1' — to mark message as spam.</param>
        public async Task<int> Delete(IEnumerable<int?> message_ids = null, bool? spam = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (message_ids != null)
                parameters.Add("message_ids", string.Join(",", message_ids));
            if (spam != null)
                parameters.Add("spam", spam.ToString());

            return await _vkontakte.GetAsync<int>("messages.delete", parameters);
        }

        /// <summary>
        /// Deletes all private messages in a conversation.
        /// Docs: <see href="https://vk.com/dev/messages.deleteDialog">messages.deleteDialog</see>
        /// </summary>
        /// <param name="user_id">User ID. To clear a chat history use 'chat_id'</param>
        /// <param name="peer_id">Destination ID.; ; "For user:; 'User ID', e.g. '12345'.; ; For chat:; '2000000000' + 'chat_id', e.g. '2000000001'.; ; For community:; '- community ID', e.g. '-12345'.; "</param>
        /// <param name="offset">Offset needed to return a specific subset of messages.</param>
        /// <param name="count">Number of messages to delete.; "NOTE: If the number of messages exceeds the maximum, the method shall be called several times."</param>
        public async Task<int> DeleteDialog(string user_id = null, int? peer_id = null, int? offset = null, int? count = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id);
            if (peer_id != null)
                parameters.Add("peer_id", peer_id.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());
            if (count != null)
                parameters.Add("count", count.ToString());

            return await _vkontakte.GetAsync<int>("messages.deleteDialog", parameters);
        }

        /// <summary>
        /// Restores a deleted message.
        /// Docs: <see href="https://vk.com/dev/messages.restore">messages.restore</see>
        /// </summary>
        /// <param name="message_id">ID of a previously-deleted message to restore.</param>
        public async Task<int> Restore(int? message_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (message_id != null)
                parameters.Add("message_id", message_id.ToString());

            return await _vkontakte.GetAsync<int>("messages.restore", parameters);
        }

        /// <summary>
        /// Marks messages as read.
        /// Docs: <see href="https://vk.com/dev/messages.markAsRead">messages.markAsRead</see>
        /// </summary>
        /// <param name="message_ids">IDs of messages to mark as read.</param>
        /// <param name="peer_id">Destination ID.; ; "For user:; 'User ID', e.g. '12345'.; ; For chat:; '2000000000' + 'chat_id', e.g. '2000000001'.; ; For community:; '- community ID', e.g. '-12345'.; "</param>
        /// <param name="start_message_id">Message ID to start from.</param>
        public async Task<int> MarkAsRead(IEnumerable<int?> message_ids = null, string peer_id = null, int? start_message_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (message_ids != null)
                parameters.Add("message_ids", string.Join(",", message_ids));
            if (peer_id != null)
                parameters.Add("peer_id", peer_id);
            if (start_message_id != null)
                parameters.Add("start_message_id", start_message_id.ToString());

            return await _vkontakte.GetAsync<int>("messages.markAsRead", parameters);
        }

        /// <summary>
        /// Marks and unmarks messages as important (starred).
        /// Docs: <see href="https://vk.com/dev/messages.markAsImportant">messages.markAsImportant</see>
        /// </summary>
        /// <param name="message_ids">IDs of messages to mark as important.</param>
        /// <param name="important">'1' — to add a star (mark as important); '0' — to remove the star</param>
        public async Task<IEnumerable<int?>> MarkAsImportant(IEnumerable<int?> message_ids = null, int? important = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (message_ids != null)
                parameters.Add("message_ids", string.Join(",", message_ids));
            if (important != null)
                parameters.Add("important", important.ToString());

            return await _vkontakte.GetAsync<IEnumerable<int?>>("messages.markAsImportant", parameters);
        }

        /// <summary>
        /// Returns data required for connection to a Long Poll server.
        /// Docs: <see href="https://vk.com/dev/messages.getLongPollServer">messages.getLongPollServer</see>
        /// </summary>
        /// <param name="use_ssl">'1' — to use SSL.</param>
        /// <param name="need_pts">'1' — to return the 'pts' field, needed for the [vk.com/dev/messages.getLongPollHistory|messages.getLongPollHistory] method.</param>
        public async Task<VkLib.Types.Messages.LongpollParams> GetLongPollServer(bool? use_ssl = null, bool? need_pts = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (use_ssl != null)
                parameters.Add("use_ssl", use_ssl.ToString());
            if (need_pts != null)
                parameters.Add("need_pts", need_pts.ToString());

            return await _vkontakte.GetAsync<VkLib.Types.Messages.LongpollParams>("messages.getLongPollServer", parameters);
        }

        /// <summary>
        /// Returns updates in user's private messages.
        /// Docs: <see href="https://vk.com/dev/messages.getLongPollHistory">messages.getLongPollHistory</see>
        /// </summary>
        /// <param name="ts">Last value of the 'ts' parameter returned from the Long Poll server or by using [vk.com/dev/messages.getLongPollHistory|messages.getLongPollHistory] method.</param>
        /// <param name="pts">Lsat value of 'pts' parameter returned from the Long Poll server or by using [vk.com/dev/messages.getLongPollHistory|messages.getLongPollHistory] method.</param>
        /// <param name="preview_length">Number of characters after which to truncate a previewed message. To preview the full message, specify '0'.; "NOTE: Messages are not truncated by default. Messages are truncated by words."</param>
        /// <param name="onlines">'1' — to return history with online users only.</param>
        /// <param name="fields">Additional profile [vk.com/dev/fields|fields] to return.</param>
        /// <param name="events_limit">Maximum number of events to return.</param>
        /// <param name="msgs_limit">Maximum number of messages to return.</param>
        /// <param name="max_msg_id">Maximum ID of the message among existing ones in the local copy. Both messages received with API methods (for example, , ), and data received from a Long Poll server (events with code 4) are taken into account.</param>
        public async Task<VkLib.Responses.Messages.GetLongPollHistoryResponse> GetLongPollHistory(int? ts = null, int? pts = null, int? preview_length = null, bool? onlines = null, IEnumerable<string> fields = null, int? events_limit = null, int? msgs_limit = null, int? max_msg_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (ts != null)
                parameters.Add("ts", ts.ToString());
            if (pts != null)
                parameters.Add("pts", pts.ToString());
            if (preview_length != null)
                parameters.Add("preview_length", preview_length.ToString());
            if (onlines != null)
                parameters.Add("onlines", onlines.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (events_limit != null)
                parameters.Add("events_limit", events_limit.ToString());
            if (msgs_limit != null)
                parameters.Add("msgs_limit", msgs_limit.ToString());
            if (max_msg_id != null)
                parameters.Add("max_msg_id", max_msg_id.ToString());

            return await _vkontakte.GetAsync<VkLib.Responses.Messages.GetLongPollHistoryResponse>("messages.getLongPollHistory", parameters);
        }

        /// <summary>
        /// Returns information about a chat.
        /// Docs: <see href="https://vk.com/dev/messages.getChat">messages.getChat</see>
        /// </summary>
        /// <param name="chat_id">Chat ID.</param>
        /// <param name="chat_ids">Chat IDs.</param>
        /// <param name="fields">Profile fields to return.;</param>
        /// <param name="name_case">Case for declension of user name and surname:; 'nom' — nominative (default); 'gen' — genitive ; 'dat' — dative; 'acc' — accusative ; 'ins' — instrumental ; 'abl' — prepositional</param>
        public async Task<VkLib.Types.Messages.Chat> GetChat(int? chat_id = null, IEnumerable<int?> chat_ids = null, IEnumerable<string> fields = null, string name_case = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (chat_id != null)
                parameters.Add("chat_id", chat_id.ToString());
            if (chat_ids != null)
                parameters.Add("chat_ids", string.Join(",", chat_ids));
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (name_case != null)
                parameters.Add("name_case", name_case);

            return await _vkontakte.GetAsync<VkLib.Types.Messages.Chat>("messages.getChat", parameters);
        }

        /// <summary>
        /// Creates a chat with several participants.
        /// Docs: <see href="https://vk.com/dev/messages.createChat">messages.createChat</see>
        /// </summary>
        /// <param name="user_ids">IDs of the users to be added to the chat.</param>
        /// <param name="title">Chat title.</param>
        public async Task<int?> CreateChat(IEnumerable<int?> user_ids = null, string title = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_ids != null)
                parameters.Add("user_ids", string.Join(",", user_ids));
            if (title != null)
                parameters.Add("title", title);

            return await _vkontakte.GetAsync<int?>("messages.createChat", parameters);
        }

        /// <summary>
        /// Edits the title of a chat.
        /// Docs: <see href="https://vk.com/dev/messages.editChat">messages.editChat</see>
        /// </summary>
        /// <param name="chat_id">Chat ID.</param>
        /// <param name="title">New title of the chat.</param>
        public async Task<int> EditChat(int? chat_id = null, string title = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (chat_id != null)
                parameters.Add("chat_id", chat_id.ToString());
            if (title != null)
                parameters.Add("title", title);

            return await _vkontakte.GetAsync<int>("messages.editChat", parameters);
        }

        /// <summary>
        /// Returns a list of IDs of users participating in a chat.
        /// Docs: <see href="https://vk.com/dev/messages.getChatUsers">messages.getChatUsers</see>
        /// </summary>
        /// <param name="chat_id">Chat ID.</param>
        /// <param name="chat_ids">Chat IDs.</param>
        /// <param name="fields">Profile fields to return.;</param>
        /// <param name="name_case">Case for declension of user name and surname:; 'nom' — nominative (default); 'gen' — genitive; 'dat' — dative; 'acc' — accusative; 'ins' — instrumental; 'abl' — prepositional</param>
        public async Task<IEnumerable<int?>> GetChatUsers(int? chat_id = null, IEnumerable<int?> chat_ids = null, IEnumerable<string> fields = null, string name_case = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (chat_id != null)
                parameters.Add("chat_id", chat_id.ToString());
            if (chat_ids != null)
                parameters.Add("chat_ids", string.Join(",", chat_ids));
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));
            if (name_case != null)
                parameters.Add("name_case", name_case);

            return await _vkontakte.GetAsync<IEnumerable<int?>>("messages.getChatUsers", parameters);
        }

        /// <summary>
        /// Changes the status of a user as typing in a conversation.
        /// Docs: <see href="https://vk.com/dev/messages.setActivity">messages.setActivity</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="type">'typing' — user has started to type.</param>
        /// <param name="peer_id">Destination ID.; ; "For user:; 'User ID', e.g. '12345'.; ; For chat:; '2000000000' + 'chat_id', e.g. '2000000001'.; ; For community:; '- community ID', e.g. '-12345'.; "</param>
        public async Task<int> SetActivity(string user_id = null, string type = null, int? peer_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id);
            if (type != null)
                parameters.Add("type", type);
            if (peer_id != null)
                parameters.Add("peer_id", peer_id.ToString());

            return await _vkontakte.GetAsync<int>("messages.setActivity", parameters);
        }

        /// <summary>
        /// Returns a list of the current user's conversations that match search criteria.
        /// Docs: <see href="https://vk.com/dev/messages.searchDialogs">messages.searchDialogs</see>
        /// </summary>
        /// <param name="q">Search query string.</param>
        /// <param name="limit">Maximum number of results.</param>
        /// <param name="fields">Profile fields to return.;</param>
        public async Task<IEnumerable<object>> SearchDialogs(string q = null, int? limit = null, IEnumerable<string> fields = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (q != null)
                parameters.Add("q", q);
            if (limit != null)
                parameters.Add("limit", limit.ToString());
            if (fields != null)
                parameters.Add("fields", string.Join(",", fields));

            return await _vkontakte.GetAsync<IEnumerable<object>>("messages.searchDialogs", parameters);
        }

        /// <summary>
        /// Adds a new user to a chat.
        /// Docs: <see href="https://vk.com/dev/messages.addChatUser">messages.addChatUser</see>
        /// </summary>
        /// <param name="chat_id">Chat ID.</param>
        /// <param name="user_id">ID of the user to be added to the chat.</param>
        public async Task<int> AddChatUser(int? chat_id = null, int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (chat_id != null)
                parameters.Add("chat_id", chat_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());

            return await _vkontakte.GetAsync<int>("messages.addChatUser", parameters);
        }

        /// <summary>
        /// Allows the current user to leave a chat or, if the current user started the chat, allows the user to remove another user from the chat.
        /// Docs: <see href="https://vk.com/dev/messages.removeChatUser">messages.removeChatUser</see>
        /// </summary>
        /// <param name="chat_id">Chat ID.</param>
        /// <param name="user_id">ID of the user to be removed from the chat.</param>
        public async Task<int> RemoveChatUser(int? chat_id = null, string user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (chat_id != null)
                parameters.Add("chat_id", chat_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id);

            return await _vkontakte.GetAsync<int>("messages.removeChatUser", parameters);
        }

        /// <summary>
        /// Returns a user's current status and date of last activity.
        /// Docs: <see href="https://vk.com/dev/messages.getLastActivity">messages.getLastActivity</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        public async Task<VkLib.Types.Messages.LastActivity> GetLastActivity(int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());

            return await _vkontakte.GetAsync<VkLib.Types.Messages.LastActivity>("messages.getLastActivity", parameters);
        }

        /// <summary>
        /// Sets a previously-uploaded picture as the cover picture of a chat.
        /// Docs: <see href="https://vk.com/dev/messages.setChatPhoto">messages.setChatPhoto</see>
        /// </summary>
        /// <param name="file">Upload URL from the 'response' field returned by the [vk.com/dev/photos.getChatUploadServer|photos.getChatUploadServer] method upon successfully uploading an image.</param>
        public async Task<VkLib.Responses.Messages.SetChatPhotoResponse> SetChatPhoto(string file = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (file != null)
                parameters.Add("file", file);

            return await _vkontakte.GetAsync<VkLib.Responses.Messages.SetChatPhotoResponse>("messages.setChatPhoto", parameters);
        }

        /// <summary>
        /// Deletes a chat's cover picture.
        /// Docs: <see href="https://vk.com/dev/messages.deleteChatPhoto">messages.deleteChatPhoto</see>
        /// </summary>
        /// <param name="chat_id">Chat ID.</param>
        public async Task<VkLib.Responses.Messages.DeleteChatPhotoResponse> DeleteChatPhoto(int? chat_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (chat_id != null)
                parameters.Add("chat_id", chat_id.ToString());

            return await _vkontakte.GetAsync<VkLib.Responses.Messages.DeleteChatPhotoResponse>("messages.deleteChatPhoto", parameters);
        }

        /// <summary>
        /// Denies sending message from community to the current user.
        /// Docs: <see href="https://vk.com/dev/messages.denyMessagesFromCommunity">messages.denyMessagesFromCommunity</see>
        /// </summary>
        /// <param name="group_id">Group ID.</param>
        public async Task<int> DenyMessagesFromCommunity(int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());

            return await _vkontakte.GetAsync<int>("messages.denyMessagesFromCommunity", parameters);
        }

        /// <summary>
        /// Allows sending messages from community to the current user.
        /// Docs: <see href="https://vk.com/dev/messages.allowMessagesFromCommunity">messages.allowMessagesFromCommunity</see>
        /// </summary>
        /// <param name="group_id">Group ID.</param>
        public async Task<int> AllowMessagesFromCommunity(int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());

            return await _vkontakte.GetAsync<int>("messages.allowMessagesFromCommunity", parameters);
        }

        /// <summary>
        /// Returns information whether sending messages from the community to current user is allowed.
        /// Docs: <see href="https://vk.com/dev/messages.isMessagesFromGroupAllowed">messages.isMessagesFromGroupAllowed</see>
        /// </summary>
        /// <param name="group_id">Group ID.</param>
        /// <param name="user_id">User ID.</param>
        public async Task<VkLib.Responses.Messages.IsMessagesFromGroupAllowedResponse> IsMessagesFromGroupAllowed(int? group_id = null, int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());

            return await _vkontakte.GetAsync<VkLib.Responses.Messages.IsMessagesFromGroupAllowedResponse>("messages.isMessagesFromGroupAllowed", parameters);
        }

    }
}
