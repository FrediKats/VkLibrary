using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VkLibrary.Core.LongPolling
{
    /// <summary>
    /// Represents long poll client.
    /// </summary>
    public class LongPollClient : IDisposable
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly Vkontakte _vkontakte;
        private bool _stopped;

        #region Constructors and Listeners

        /// <summary>
        /// Inits a LongPollClient using extended settings.
        /// </summary>
        /// <param name="key">Secret session key.</param>
        /// <param name="vkontakte">Library instance whose logger to use</param>
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
        internal LongPollClient(Vkontakte vkontakte, string server, string key, int ts, 
            int version = 1, int wait = 25, AnswerFlags mode = AnswerFlags.ReceiveAttachments)
        {
            _vkontakte = vkontakte;
            StartListener(server, key, ts, version, wait, mode);
        }

        /// <summary>
        /// Builds LongPollServer url.
        /// </summary>
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
        public static string GetRequestUrl(string server, string key, int ts, int version = 1,
            int wait = 25, AnswerFlags mode = AnswerFlags.ReceiveAttachments) =>
            Vkontakte.BuildUrl($"https://{server}", new Dictionary<string, string>
            {
                { "version", version.ToString() },
                { "wait", wait.ToString() },
                { "mode", ((int)mode).ToString() },
                { "ts", ts.ToString() },
                { "act", "a_check" },
                { "key", key }
            });

        /// <summary>
        /// Starts a long poll listener.
        /// </summary>
        private async void StartListener(string server, string key, 
            int ts, int version, int wait, AnswerFlags mode) => 
            await Task.Run(async () =>
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
                        Dispose();
                        return;
                    }

                    // Raise messageReceived and continue.
                    OnLongPollMessageReceived(updates);
                    ts = (int) responseToken["ts"];
                }
            });

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
                var eventCode = (LongPollMessageCodes)(int)array[0];
                Log($"Received event with code: {eventCode}");

                // Raise events.
                switch (eventCode)
                {
                    case LongPollMessageCodes.ReplaceMessageFlags:
                        Call(ReplaceMessageFlagsEvent, array);
                        break;
                    case LongPollMessageCodes.InstallMessageFlags:
                        Call(InstallMessageFlagsEvent, array);
                        break;
                    case LongPollMessageCodes.ResetMessageFlags:
                        Call(ResetMessageFlagsEvent, array);
                        break;
                    case LongPollMessageCodes.AddMessage:
                        Call(AddMessageEvent, array);
                        break;
                    case LongPollMessageCodes.ReadAllIncomingMessages:
                        Call(ReadAllIncomingMessagesEvent, array);
                        break;
                    case LongPollMessageCodes.ReadAllOutgoingMessages:
                        Call(ReadAllOutgoingMessagesEvent, array);
                        break;
                    case LongPollMessageCodes.FriendOnline:
                        Call(FriendOnlineEvent, array);
                        break;
                    case LongPollMessageCodes.FriendOffline:
                        Call(FriendOfflineEvent, array);
                        break;
                    case LongPollMessageCodes.ResetDialogFlags:
                        Call(ResetDialogFlagsEvent, array);
                        break;
                    case LongPollMessageCodes.ReplaceDialogFlags:
                        Call(ReplaceDialogFlagsEvent, array);
                        break;
                    case LongPollMessageCodes.InstallDialogFlags:
                        Call(InstallDialogFlagsEvent, array);
                        break;
                    case LongPollMessageCodes.ConversationChanged:
                        Call(ConversationChangedEvent, array);
                        break;
                    case LongPollMessageCodes.UserTypingInDialog:
                        Call(UserTypingInDialogEvent, array);
                        break;
                    case LongPollMessageCodes.UserTypingInConversation:
                        Call(UserTypingInConversationEvent, array);
                        break;
                    case LongPollMessageCodes.UserCall:
                        Call(UserCallEvent, array);
                        break;
                    case LongPollMessageCodes.CounterUpdate:
                        Call(CounterUpdateEvent, array);
                        break;
                    case LongPollMessageCodes.NotificationSettingsChanged:
                        Call(NotificationSettingsChangedEvent, array);
                        break;
                    default: 
                        return;
                }
            }
        }

        /// <summary>
        /// Call double-tupled event handler.
        /// </summary>
        /// <param name="eventHandler">Handler to call.</param>
        /// <param name="token">JArray to parse</param>
        private void Call<TFirst, TSecond>(EventHandler<Tuple<TFirst, TSecond>> eventHandler, JArray token) =>
            eventHandler?.Invoke(this, new Tuple<TFirst, TSecond>(token[1].ToObject<TFirst>(),
                token[2].ToObject<TSecond>()));

        /// <summary>
        /// Call triple-tupled event handler.
        /// </summary>
        /// <param name="eventHandler">Handler to call.</param>
        /// <param name="token">JArray to parse</param>
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
        public event EventHandler<Tuple<int, MessageFlags, JToken>> ReplaceMessageFlagsEvent;

        /// <summary>
        /// InstallMessageFlags LongPoll event.
        /// Item1 is MessageId, Item2 is Flags, Item3 is JToken that may contain additional fields.
        /// </summary>
        public event EventHandler<Tuple<int, MessageFlags, JToken>> InstallMessageFlagsEvent;

        /// <summary>
        /// ResetMessageFlags LongPoll event.
        /// Item1 is MessageId, Item2 is Flags, Item3 is JToken that may contain additional fields.
        /// </summary>
        public event EventHandler<Tuple<int, MessageFlags, JToken>> ResetMessageFlagsEvent;

        /// <summary>
        /// AddMessage LongPoll event. 
        /// Item1 is MessageId, Item2 is Flags, Item3 is JToken that may contain additional fields.
        /// </summary>
        public event EventHandler<Tuple<int, MessageFlags, JToken>> AddMessageEvent;

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
        public event EventHandler<Tuple<int, MessageFlags>> UserTypingInConversationEvent;

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
        private void Log(object o) => _vkontakte.Log(o);

        /// <summary>
        /// Stops current long poll client.
        /// </summary>
        public void Stop() => _stopped = true;

        /// <summary>
        /// Disposes object.
        /// </summary>
        public void Dispose()
        {
            // Stop and free resources.
            _stopped = true;
            _httpClient?.Dispose();
        }

        #endregion
    }
}
