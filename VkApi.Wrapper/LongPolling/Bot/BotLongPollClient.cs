using System;
using Newtonsoft.Json.Linq;
using VkApi.Wrapper.LongPolling.Bot.Responses;
using VkApi.Wrapper.Objects;

namespace VkApi.Wrapper.LongPolling.Bot
{
    /// <summary>
    /// Represents long poll client for bots.
    /// </summary>
    public class BotLongPollClient : BaseLongPollClient
    {
        /// <summary>Inits a LongPollClient using extended settings.</summary>
        /// <param name="vkontakte">Library instance whose logger to use</param>
        internal BotLongPollClient(Vkontakte vkontakte) : base(vkontakte) { }

        public override void Handle(JToken jToken)
        {
            JToken argumentObject = jToken["object"];
            BotLongPollMessageCodes eventCode;
            try
            {
                eventCode = jToken["type"].ToObject<BotLongPollMessageCodes>();

            }
            catch
            {
                eventCode = BotLongPollMessageCodes.Unknown;
            }

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
                    Call(OnVideoCommentEdit, argumentObject);
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
                    Log($"Unexpected event type: {jToken["type"]}");
                    break;
            }
        }

        #region Events

        /// <summary>
        /// MessageNew LongPoll event
        /// </summary>
        public event EventHandler<MessagesMessage> OnMessageNew;

        /// <summary>
        /// MessageReply LongPoll event
        /// </summary>
        public event EventHandler<MessagesMessage> OnMessageReply;

        /// <summary>
        /// MessageAllow LongPoll event
        /// </summary>
        public event EventHandler<CallbackMessageAllow> OnMessageAllow;
        /// <summary>
        /// MessageDeny LongPoll event
        /// </summary>
        public event EventHandler<CallbackMessageDeny> OnMessageDeny;

        /// <summary>
        /// PhotoNew LongPoll event
        /// </summary>
        public event EventHandler<PhotosPhoto> OnPhotoNew;

        /// <summary>
        /// PhotoCommentNew LongPoll event
        /// </summary>
        public event EventHandler<PhotoCommentResponse> OnPhotoCommentNew;

        /// <summary>
        /// PhotoCommentEdit LongPoll event
        /// </summary>
        public event EventHandler<PhotoCommentResponse> OnPhotoCommentEdit;

        /// <summary>
        /// PhotoCommentRestore LongPoll event
        /// </summary>
        public event EventHandler<PhotoCommentResponse> OnPhotoCommentRestore;

        /// <summary>
        /// PhotoCommentDelete LongPoll event
        /// </summary>
        public event EventHandler<CallbackPhotoCommentDelete> OnPhotoCommentDelete;


        /// <summary>
        /// AudioNew LongPoll event
        /// </summary>
        public event EventHandler<AudioAudio> OnAudioNew;

        /// <summary>
        /// VideoNew LongPoll event
        /// </summary>
        public event EventHandler<VideoVideo> OnVideoNew;

        /// <summary>
        /// VideoCommentNew LongPoll event
        /// </summary>
        public event EventHandler<CallbackVideoComment> OnVideoCommentNew;

        /// <summary>
        /// VideoCommentEdit LongPoll event
        /// </summary>
        public event EventHandler<CallbackVideoComment> OnVideoCommentEdit;

        /// <summary>
        /// VideoCommentRestore LongPoll event
        /// </summary>
        public event EventHandler<CallbackVideoComment> OnVideoCommentRestore;

        /// <summary>
        /// VideoCommentDelete LongPoll event
        /// </summary>
        public event EventHandler<CallbackVideoCommentDelete> OnVideoCommentDelete;

        /// <summary>
        /// WallPostNew LongPoll event
        /// </summary>
        public event EventHandler<WallWallpost> OnWallPostNew;

        /// <summary>
        /// WallRepost LongPoll event
        /// </summary>
        public event EventHandler<WallWallpost> OnWallRepost;


        /// <summary>
        /// WallReplyNew LongPoll event
        /// </summary>
        public event EventHandler<WallReplyResponse> OnWallReplyNew;

        /// <summary>
        /// WallReplyEdit LongPoll event
        /// </summary>
        public event EventHandler<WallReplyResponse> OnWallReplyEdit;

        /// <summary>
        /// WallReplyRestore LongPoll event
        /// </summary>
        public event EventHandler<WallReplyResponse> OnWallReplyRestore;

        /// <summary>
        /// WallReplyDelete LongPoll event
        /// </summary>
        public event EventHandler<CallbackWallCommentDelete> OnWallReplyDelete;

        /// <summary>
        /// BoardPostNew LongPoll event
        /// </summary>
        public event EventHandler<BoardTopicResponse> OnBoardPostNew;

        /// <summary>
        /// BoardPostEdit LongPoll event
        /// </summary>
        public event EventHandler<BoardTopicResponse> OnBoardPostEdit;

        /// <summary>
        /// BoardPostRestore LongPoll event
        /// </summary>
        public event EventHandler<BoardTopicResponse> OnBoardPostRestore;

        /// <summary>
        /// BoardPostDelete LongPoll event
        /// </summary>
        public event EventHandler<CallbackBoardPostDelete> OnBoardPostDelete;

        /// <summary>
        /// MarketCommentNew LongPoll event
        /// </summary>
        public event EventHandler<CallbackMarketComment> OnMarketCommentNew;

        /// <summary>
        /// MarketCommentEdit LongPoll event
        /// </summary>
        public event EventHandler<CallbackMarketComment> OnMarketCommentEdit;

        /// <summary>
        /// MarketCommentRestore LongPoll event
        /// </summary>
        public event EventHandler<CallbackMarketComment> OnMarketCommentRestore;

        /// <summary>
        /// MarketCommentDelete LongPoll event
        /// </summary>
        public event EventHandler<CallbackMarketCommentDelete> OnMarketCommentDelete;

        /// <summary>
        /// GroupLeave LongPoll event
        /// </summary>
        public event EventHandler<CallbackGroupLeave> OnGroupLeave;

        /// <summary>
        /// GroupJoin LongPoll event
        /// </summary>
        public event EventHandler<CallbackGroupJoin> OnGroupJoin;

        /// <summary>
        /// UserBlock LongPoll event
        /// </summary>
        public event EventHandler<CallbackUserBlock> OnUserBlock;

        /// <summary>
        /// UserUnblock LongPoll event
        /// </summary>
        public event EventHandler<CallbackUserUnblock> OnUserUnblock;

        /// <summary>
        /// PollVoteNew LongPoll event
        /// </summary>
        public event EventHandler<CallbackPollVoteNew> OnPollVoteNew;

        /// <summary>
        /// GroupOfficersEdit LongPoll event
        /// </summary>
        public event EventHandler<CallbackGroupOfficersEdit> OnGroupOfficersEdit;

        /// <summary>
        /// GroupChangeSettings LongPoll event
        /// </summary>
        public event EventHandler<CallbackGroupChangeSettings> OnGroupChangeSettings;

        /// <summary>
        /// GroupChangePhoto LongPoll event
        /// </summary>
        public event EventHandler<CallbackGroupChangePhoto> OnGroupChangePhoto;

        #endregion
    }
}