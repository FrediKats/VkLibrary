using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using VkApi.Wrapper.LongPolling.Bot.Responses;
using VkLibrary.Core;
using VkLibrary.Core.Objects;

namespace VkApi.Wrapper.LongPolling.Bot
{
    /// <summary>
    /// Represents long poll client for bots.
    /// </summary>
    public class BotLongPollClient
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly Vkontakte _vkontakte;
        private bool _stopped;

        /// <summary>Inits a LongPollClient using extended settings.</summary>
        /// <param name="vkontakte">Library instance whose logger to use</param>
        internal BotLongPollClient(Vkontakte vkontakte) => _vkontakte = vkontakte;

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
            string key, int ts, int version = 1, int wait = 25)
        {
            return _vkontakte.HttpService.BuildGetRequestUrl(server, new Dictionary<string, string>
            {
                {"version", version.ToString()},
                {"wait", wait.ToString()},
                {"ts", ts.ToString()},
                {"act", "a_check"},
                {"key", key}
            });
        }

        /// <summary>
        /// Starts a long poll listener.
        /// </summary>
        internal async Task StartListener(string server, string key, int ts, int version, int wait)
        {
            await Task.Factory.StartNew(async () =>
            {
                while (!_stopped)
                {
                    // Send request and receive data.
                    var requestUrl = GetRequestUrl(server, key, ts, version, wait);
                    var responseString = await _httpClient.GetStringAsync(requestUrl);
                    var responseToken = JsonConvert.DeserializeObject<JToken>(responseString);

                    // Get values.
                    var failure = responseToken["failed"];
                    var updates = responseToken["updates"];

                    // Raise failure and stop the listener.
                    if (failure != null || updates == null)
                    {
                        OnLongPollFailureReceived(failure == null ? -1 : (int)failure);
                        Stop();
                    }
                    else
                    {
                        // Raise messageReceived and continue.
                        OnLongPollMessageReceived(updates);
                        ts = int.Parse(responseToken["ts"].ToString());
                    }
                }
                _httpClient?.Dispose();
            }, TaskCreationOptions.LongRunning);
        }

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
                JToken argumentObject = jToken["object"];


                BotLongPollMessageCodes? eventCode = null;
                try
                {
                    var namingStrategy = new SnakeCaseNamingStrategy();
                    namingStrategy.ProcessDictionaryKeys = true;
                    var settings = new JsonSerializerSettings
                    {
                        ContractResolver = new DefaultContractResolver
                        {
                            NamingStrategy = namingStrategy
                        },
                        Converters =
                        {
                            new StringEnumConverter(false)
                        }
                    };

                    eventCode = jToken["type"].ToObject<BotLongPollMessageCodes?>();
                }
                catch (Exception e)
                {
                    Log($"{e.Message}\n{e.StackTrace}");
                }
                

                // Get basic event information.
                if (eventCode == null)
                {
                    Log($"Don't support bot long poll type: {jToken["type"]}");
                    continue;
                }

                Log($"Received event with code: {eventCode}");

                // Raise events.
                //TODO: implement cases
                switch (eventCode)
                {
                    case BotLongPollMessageCodes.MessageNew:
                        Call(OnMessageNew, argumentObject);
                        break;
                    case BotLongPollMessageCodes.MessageReply:
                        Call(OnMessageReply, argumentObject);
                        break;
                    case BotLongPollMessageCodes.MessageAllow:
                        Call(OnMessageAllow, argumentObject);
                        break;
                    case BotLongPollMessageCodes.MessageDeny:
                        Call(OnMessageDeny, argumentObject);
                        break;
                    case BotLongPollMessageCodes.PhotoNew:
                        Call(OnPhotoNew, argumentObject);
                        break;
                    case BotLongPollMessageCodes.PhotoCommentNew:
                        Call(OnPhotoCommentNew, argumentObject);
                        break;
                    case BotLongPollMessageCodes.PhotoCommentEdit:
                        Call(OnPhotoCommentEdit, argumentObject);
                        break;
                    case BotLongPollMessageCodes.PhotoCommentRestore:
                        Call(OnPhotoCommentRestore, argumentObject);
                        break;
                    case BotLongPollMessageCodes.PhotoCommentDelete:
                        Call(OnPhotoCommentDelete, argumentObject);
                        break;
                    case BotLongPollMessageCodes.AudioNew:
                        Call(OnAudioNew, argumentObject);
                        break;
                    case BotLongPollMessageCodes.VideoNew:
                        Call(OnVideoNew, argumentObject);
                        break;
                    case BotLongPollMessageCodes.VideoCommentNew:
                        Call(OnVideoCommentNew, argumentObject);
                        break;
                    case BotLongPollMessageCodes.VideoCommentEdit:
                        Call(OnVideoCommentNew, argumentObject);
                        break;
                    case BotLongPollMessageCodes.VideoCommentRestore:
                        Call(OnVideoCommentRestore, argumentObject);
                        break;
                    case BotLongPollMessageCodes.VideoCommentDelete:
                        Call(OnVideoCommentDelete, argumentObject);
                        break;
                    case BotLongPollMessageCodes.WallPostNew:
                        Call(OnWallPostNew, argumentObject);
                        break;
                    case BotLongPollMessageCodes.WallRepost:
                        Call(OnWallRepost, argumentObject);
                        break;
                    case BotLongPollMessageCodes.WallReplyNew:
                        Call(OnWallReplyNew, argumentObject);
                        break;
                    case BotLongPollMessageCodes.WallReplyEdit:
                        Call(OnWallReplyEdit, argumentObject);
                        break;
                    case BotLongPollMessageCodes.WallReplyRestore:
                        Call(OnWallReplyRestore, argumentObject);
                        break;
                    case BotLongPollMessageCodes.WallReplyDelete:
                        Call(OnWallReplyDelete, argumentObject);
                        break;
                    case BotLongPollMessageCodes.BoardPostNew:
                        Call(OnBoardPostNew, argumentObject);
                        break;
                    case BotLongPollMessageCodes.BoardPostEdit:
                        Call(OnBoardPostEdit, argumentObject);
                        break;
                    case BotLongPollMessageCodes.BoardPostRestore:
                        Call(OnBoardPostRestore, argumentObject);
                        break;
                    case BotLongPollMessageCodes.BoardPostDelete:
                        Call(OnBoardPostDelete, argumentObject);
                        break;
                    case BotLongPollMessageCodes.MarketCommentNew:
                        Call(OnMarketCommentNew, argumentObject);
                        break;
                    case BotLongPollMessageCodes.MarketCommentEdit:
                        Call(OnMarketCommentEdit, argumentObject);
                        break;
                    case BotLongPollMessageCodes.MarketCommentRestore:
                        Call(OnMarketCommentRestore, argumentObject);
                        break;
                    case BotLongPollMessageCodes.MarketCommentDelete:
                        Call(OnMarketCommentDelete, argumentObject);
                        break;
                    case BotLongPollMessageCodes.GroupLeave:
                        Call(OnGroupLeave, argumentObject);
                        break;
                    case BotLongPollMessageCodes.GroupJoin:
                        Call(OnGroupJoin, argumentObject);
                        break;
                    case BotLongPollMessageCodes.UserBlock:
                        Call(OnUserBlock, argumentObject);
                        break;
                    case BotLongPollMessageCodes.UserUnblock:
                        Call(OnUserUnblock, argumentObject);
                        break;
                    case BotLongPollMessageCodes.PollVoteNew:
                        Call(OnPollVoteNew, argumentObject);
                        break;
                    case BotLongPollMessageCodes.GroupOfficersEdit:
                        Call(OnGroupOfficersEdit, argumentObject);
                        break;
                    case BotLongPollMessageCodes.GroupChangeSettings:
                        Call(OnGroupChangeSettings, argumentObject);
                        break;
                    case BotLongPollMessageCodes.GroupChangePhoto:
                        Call(OnGroupChangePhoto, argumentObject);
                        break;
                    default:
                        Log($"Don't add long poll handler for {eventCode}");
                        break;
                }
            }
        }

        private void Call<TFirst>(EventHandler<TFirst> eventHandler, JToken value) =>
            eventHandler?.Invoke(this, value.ToObject<TFirst>());

        #region Events

        /// <summary>
        /// Invoked when VK's LongPoll server answers a query (each 25 seconds by default). 
        /// Arguments contain JSON array with updates codes.
        /// </summary>
        public event EventHandler<JArray> ResponseReceived;

        public event EventHandler<MessagesMessage> OnMessageNew;
        public event EventHandler<MessagesMessage> OnMessageReply;
        public event EventHandler<CallbackMessageAllow> OnMessageAllow;
        public event EventHandler<CallbackMessageDeny> OnMessageDeny;

        public event EventHandler<PhotosPhoto> OnPhotoNew;
        public event EventHandler<PhotoCommentResponse> OnPhotoCommentNew;
        public event EventHandler<PhotoCommentResponse> OnPhotoCommentEdit;
        public event EventHandler<PhotoCommentResponse> OnPhotoCommentRestore;
        public event EventHandler<CallbackPhotoCommentDelete> OnPhotoCommentDelete;

        public event EventHandler<AudioAudio> OnAudioNew;

        public event EventHandler<VideoVideo> OnVideoNew;
        public event EventHandler<CallbackVideoComment> OnVideoCommentNew;
        public event EventHandler<CallbackVideoComment> OnVideoCommentEdit;
        public event EventHandler<CallbackVideoComment> OnVideoCommentRestore;
        public event EventHandler<CallbackVideoCommentDelete> OnVideoCommentDelete;

        public event EventHandler<WallWallpost> OnWallPostNew;
        public event EventHandler<WallWallpost> OnWallRepost;

        public event EventHandler<WallReplyResponse> OnWallReplyNew;
        public event EventHandler<WallReplyResponse> OnWallReplyEdit;
        public event EventHandler<WallReplyResponse> OnWallReplyRestore;
        public event EventHandler<CallbackWallCommentDelete> OnWallReplyDelete;

        public event EventHandler<BoardTopicResponse> OnBoardPostNew;
        public event EventHandler<BoardTopicResponse> OnBoardPostEdit;
        public event EventHandler<BoardTopicResponse> OnBoardPostRestore;
        public event EventHandler<CallbackBoardPostDelete> OnBoardPostDelete;

        public event EventHandler<CallbackMarketComment> OnMarketCommentNew;
        public event EventHandler<CallbackMarketComment> OnMarketCommentEdit;
        public event EventHandler<CallbackMarketComment> OnMarketCommentRestore;
        public event EventHandler<CallbackMarketCommentDelete> OnMarketCommentDelete;

        public event EventHandler<CallbackGroupLeave> OnGroupLeave;
        public event EventHandler<CallbackGroupJoin> OnGroupJoin;
        public event EventHandler<CallbackUserBlock> OnUserBlock;
        public event EventHandler<CallbackUserUnblock> OnUserUnblock;

        public event EventHandler<CallbackPollVoteNew> OnPollVoteNew;
        public event EventHandler<CallbackGroupOfficersEdit> OnGroupOfficersEdit;
        public event EventHandler<CallbackGroupChangeSettings> OnGroupChangeSettings;
        public event EventHandler<CallbackGroupChangePhoto> OnGroupChangePhoto;

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