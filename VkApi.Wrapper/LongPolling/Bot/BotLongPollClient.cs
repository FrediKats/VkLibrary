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
                    Log($"Unexpected event type: {jToken["type"]}");
                    break;
            }
        }

        #region Events

        /// <summary>
        /// Invoked when VK's LongPoll server answers a query (each 25 seconds by default). 
        /// Arguments contain JSON array with updates codes.
        /// </summary>
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
    }
}