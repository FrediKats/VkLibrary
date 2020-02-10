using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VkLibrary.Core;

namespace VkApi.Wrapper.LongPolling.User
{
    /// <summary>
    /// Represents long poll client.
    /// </summary>
    public class UserLongPollClient
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly Vkontakte _vkontakte;
        private bool _stopped;

        #region Constructors and Listeners

        /// <summary>Inits a UserLongPollClient using extended settings.</summary>
        /// <param name="vkontakte">Library instance whose logger to use</param>
        internal UserLongPollClient(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>Builds LongPollServer url.</summary>
        /// <param name="key">Secret session key.</param>
        /// <param name="server">Server address to which you need to send the request</param>
        /// <param name="ts">Number of the last event from which you want to receive data</param>
        /// <param name="mode">Additional answer options.</param>
        /// <param name="version">
        /// Actual version: 1. For version 0 (default), community IDs will arrive in the format 
        /// group_id + 1000000000 for saving backward compatibility. 
        /// We recommend using the updated version.
        /// </param>
        /// <param name="wait">
        /// Waiting period (as most proxy servers terminate the connection after 30 seconds, 
        /// we recommend indicating wait = 25). Maximum: 90. 
        /// </param>
        /// <returns>Built request url that can be used to retrieve data from vk long poll servers.</returns>
        /// ReSharper disable once MemberCanBePrivate.Global
        public Uri GetRequestUrl(string server, 
            string key, int ts, int version = 1, int wait = 25, 
            AnswerFlags mode = AnswerFlags.ReceiveAttachments)
        {
            return _vkontakte.HttpService.BuildGetRequestUrl($"https://{server}", new Dictionary<string, string>
            {
                {"version", version.ToString()},
                {"wait", wait.ToString()},
                {"mode", ((int) mode).ToString()},
                {"ts", ts.ToString()},
                {"act", "a_check"},
                {"key", key}
            });
        }

        /// <summary>
        /// Starts a long poll listener.
        /// </summary>
        internal async Task StartListener(string server, string key, int ts, int version, int wait, AnswerFlags mode)
        {
            await Task.Factory.StartNew(async () =>
            {
                while (!_stopped)
                {
                    // Send request and receive data.
                    var requestUrl = GetRequestUrl(server, key, ts, version, wait, mode);
                    var responseString = await _httpClient.GetStringAsync(requestUrl);
                    var responseToken = JsonConvert.DeserializeObject<JToken>(responseString);

                    // Get values.
                    var failure = responseToken["failed"];
                    var updates = responseToken["updates"];

                    // Raise failure and stop the listener.
                    if (failure != null || updates == null)
                    {
                        OnLongPollFailureReceived(failure == null ? -1 : (int) failure);
                        Stop();
                    }
                    else
                    {
                        // Raise messageReceived and continue.
                        OnLongPollMessageReceived(updates);
                        ts = (int)responseToken["ts"];
                    }
                }
                _httpClient?.Dispose();
            }, TaskCreationOptions.LongRunning);
        }

        #endregion

        #region Some kinds of events received

        /// <summary>
        /// Should be invoked when updates are received by long poll client.
        /// </summary>
        /// <param name="args">JToken args received.</param>
        private void OnLongPollMessageReceived(JToken args)
        {
            // Deserialize array of arrays containing events.
            Log($"Received updates response: {args.ToString(Formatting.None)}");
            var updatesArray = (JArray)args;
            ResponseReceived?.Invoke(this, updatesArray);

            // Iterate throug all elements in array.
            foreach (var jToken in updatesArray)
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

        #region Long Poll client events

        /// <summary>
        /// Invoked when VK's LongPoll server answers a query (each 25 seconds by default). 
        /// Arguments contain JSON array with updates codes.
        /// </summary>
        public event EventHandler<JArray> ResponseReceived;

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

        #endregion

        #region Failure received events

        /// <summary>
        /// Should be invoked when a new failure is received by long poll client.
        /// </summary>
        /// <param name="args">JToken args received.</param>
        private void OnLongPollFailureReceived(int args) => LongPollFailureReceived?.Invoke(this, args);

        /// <summary>
        /// Invoked when new long poll failure is received.
        /// </summary>
        public event EventHandler<int> LongPollFailureReceived;

        #endregion

        #region Client methods

        /// <summary>
        /// Logs to debug using internal logger.
        /// </summary>
        /// <param name="o">Object to stringify and log</param>
        private void Log(object o) => _vkontakte.Logger.Log(o);

        /// <summary>
        /// Stops and disposes this long poll client.
        /// </summary>
        public void Stop() => _stopped = true;

        #endregion
    }
}
