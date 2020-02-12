using System;
using Newtonsoft.Json.Linq;
using VkLibrary.Core;

namespace VkApi.Wrapper.LongPolling.User
{
    /// <summary>
    /// Represents long poll client.
    /// </summary>
    public class UserLongPollClient : BaseLongPollClient
    {
        /// <summary>Inits a UserLongPollClient using extended settings.</summary>
        /// <param name="vkontakte">Library instance whose logger to use</param>
        internal UserLongPollClient(Vkontakte vkontakte) : base(vkontakte) { }

        #region Some kinds of events received

        public override void Handle(JToken jToken)
        {
            // Get basic event information.
            var array = (JArray)jToken;
            var eventCode = (UserLongPollMessageCodes)(int)array[0];
            Log($"Received event with code: {eventCode}");

            // Raise events.
            switch (eventCode)
            {
                case UserLongPollMessageCodes.ReplaceMessageFlags:
                    CallEx(ReplaceMessageFlagsEvent, array);
                    break;
                case UserLongPollMessageCodes.InstallMessageFlags:
                    CallEx(InstallMessageFlagsEvent, array);
                    break;
                case UserLongPollMessageCodes.ResetMessageFlags:
                    CallEx(ResetMessageFlagsEvent, array);
                    break;
                case UserLongPollMessageCodes.AddMessage:
                    CallEx(AddMessageEvent, array);
                    break;
                case UserLongPollMessageCodes.ReadAllIncomingMessages:
                    Call(ReadAllIncomingMessagesEvent, array);
                    break;
                case UserLongPollMessageCodes.ReadAllOutgoingMessages:
                    Call(ReadAllOutgoingMessagesEvent, array);
                    break;
                case UserLongPollMessageCodes.FriendOnline:
                    Call(FriendOnlineEvent, array);
                    break;
                case UserLongPollMessageCodes.FriendOffline:
                    Call(FriendOfflineEvent, array);
                    break;
                case UserLongPollMessageCodes.ResetDialogFlags:
                    Call(ResetDialogFlagsEvent, array);
                    break;
                case UserLongPollMessageCodes.ReplaceDialogFlags:
                    Call(ReplaceDialogFlagsEvent, array);
                    break;
                case UserLongPollMessageCodes.InstallDialogFlags:
                    Call(InstallDialogFlagsEvent, array);
                    break;
                case UserLongPollMessageCodes.ConversationChanged:
                    Call(ConversationChangedEvent, array);
                    break;
                case UserLongPollMessageCodes.UserTypingInDialog:
                    Call(UserTypingInDialogEvent, array);
                    break;
                case UserLongPollMessageCodes.UserTypingInConversation:
                    Call(UserTypingInConversationEvent, array);
                    break;
                case UserLongPollMessageCodes.UserCall:
                    Call(UserCallEvent, array);
                    break;
                case UserLongPollMessageCodes.CounterUpdate:
                    Call(CounterUpdateEvent, array);
                    break;
                case UserLongPollMessageCodes.NotificationSettingsChanged:
                    Call(NotificationSettingsChangedEvent, array);
                    break;
                default:
                    return;
            }
        }

        private void CallEx<TFirst, TSecond>(EventHandler<Tuple<TFirst, TSecond, JArray>> eventHandler, JArray token) =>
            eventHandler?.Invoke(this, new Tuple<TFirst, TSecond, JArray>(token[1].ToObject<TFirst>(),
                token[2].ToObject<TSecond>(), token));

        private void Call<TFirst, TSecond>(EventHandler<Tuple<TFirst, TSecond>> eventHandler, JArray token) =>
            eventHandler?.Invoke(this, new Tuple<TFirst, TSecond>(token[1].ToObject<TFirst>(),
                token[2].ToObject<TSecond>()));

        private void Call<TFirst, TSecond, TThird>(EventHandler<Tuple<TFirst, TSecond, TThird>> eventHandler, JArray token) =>
            eventHandler?.Invoke(this, new Tuple<TFirst, TSecond, TThird>(token[1].ToObject<TFirst>(), 
                token[2].ToObject<TSecond>(), token[3].ToObject<TThird>()));

        #endregion

        /// <summary>
        /// ReplaceMessageFlags LongPoll event. 
        /// Item1 is MessageId, Item2 is Flags, Item3 is JToken that may contain additional fields.
        /// </summary>
        public event EventHandler<Tuple<int, MessageFlags, JArray>> ReplaceMessageFlagsEvent;

        /// <summary>
        /// InstallMessageFlags LongPoll event.
        /// Item1 is MessageId, Item2 is Flags, Item3 is JToken that may contain additional fields.
        /// </summary>
        public event EventHandler<Tuple<int, MessageFlags, JArray>> InstallMessageFlagsEvent;

        /// <summary>
        /// ResetMessageFlags LongPoll event.
        /// Item1 is MessageId, Item2 is Flags, Item3 is JToken that may contain additional fields.
        /// </summary>
        public event EventHandler<Tuple<int, MessageFlags, JArray>> ResetMessageFlagsEvent;

        /// <summary>
        /// AddMessage LongPoll event. 
        /// Item1 is MessageId, Item2 is Flags, Item3 is JToken that may contain additional fields.
        /// </summary>
        public event EventHandler<Tuple<int, MessageFlags, JArray>> AddMessageEvent;

        /// <summary>
        /// ReadAllIncomingMessages LongPoll event.
        /// Item1 is PeerId, Item2 is LocalId.
        /// </summary>
        public event EventHandler<Tuple<int, int>> ReadAllIncomingMessagesEvent;

        /// <summary>
        /// ReadAllOutgoingMessages LongPoll event.
        /// Item1 is PeerId, Item2 is LocalId.
        /// </summary>
        public event EventHandler<Tuple<int, int>> ReadAllOutgoingMessagesEvent;

        /// <summary>
        /// FriendOnline LongPoll event.
        /// Item1 is -UserId, Item2 is Extra.
        /// </summary>
        public event EventHandler<Tuple<int, PlatformFlags>> FriendOnlineEvent;

        /// <summary>
        /// FriendOffline LongPoll event.
        /// Item1 is -UserId, Item2 is Flags.
        /// </summary>
        public event EventHandler<Tuple<int, PlatformFlags>> FriendOfflineEvent;

        /// <summary>
        /// ResetDialogFlags LongPoll event.
        /// Item1 is PeerId, Item2 is Mask.
        /// </summary>
        public event EventHandler<Tuple<int, DialogFlags>> ResetDialogFlagsEvent;

        /// <summary>
        /// ReplaceDialogFlags LongPoll event.
        /// Item1 is PeerId, Item2 is Flags.
        /// </summary>
        public event EventHandler<Tuple<int, DialogFlags>> ReplaceDialogFlagsEvent;

        /// <summary>
        /// InstallDialogFlags LongPoll event.
        /// Item1 is PeerId, Item2 is Mask.
        /// </summary>
        public event EventHandler<Tuple<int, DialogFlags>> InstallDialogFlagsEvent;

        /// <summary>
        /// ConversationChanged LongPoll event.
        /// Item1 is ChatId, Item2 is Self.
        /// </summary>
        public event EventHandler<Tuple<int, int>> ConversationChangedEvent;

        /// <summary>
        /// UserTypingInDialog LongPoll event.
        /// Item1 is UserId, Item2 is Flags.
        /// </summary>
        public event EventHandler<Tuple<int, MessageFlags>> UserTypingInDialogEvent;

        /// <summary>
        /// UserTypingInDialog LongPoll event.
        /// Item1 is UserId, Item2 is ChatId.
        /// </summary>
        public event EventHandler<Tuple<int, int>> UserTypingInConversationEvent;

        /// <summary>
        /// UserCall LongPoll event.
        /// Item1 is UserId, Item2 is CallId.
        /// </summary>
        public event EventHandler<Tuple<int, int>> UserCallEvent;

        /// <summary>
        /// CounterUpdate LongPoll event.
        /// ItemId is Count, Item2 is Zero.
        /// </summary>
        public event EventHandler<Tuple<int, int>> CounterUpdateEvent;

        /// <summary>
        /// NotificationSettingsChanged LongPoll event.
        /// Item1 is PeerId, Item2 is Sound, Item3 is DisabledUntil.
        /// </summary>
        public event EventHandler<Tuple<int, int, int>> NotificationSettingsChangedEvent;
    }
}
