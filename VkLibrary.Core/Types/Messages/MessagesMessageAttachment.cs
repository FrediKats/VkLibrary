using Newtonsoft.Json;
using VkApi.Wrapper.Types.Audio;
using VkApi.Wrapper.Types.Base;
using VkApi.Wrapper.Types.Docs;
using VkApi.Wrapper.Types.Gifts;
using VkApi.Wrapper.Types.Market;
using VkApi.Wrapper.Types.Photos;
using VkApi.Wrapper.Types.Video;
using VkApi.Wrapper.Types.Wall;

namespace VkApi.Wrapper.Types.Messages
{
    public class MessagesMessageAttachment
    {
        [JsonProperty("audio")]
        public AudioAudio Audio { get; set; }
        [JsonProperty("audio_message")]
        public MessagesAudioMessage AudioMessage { get; set; }
        [JsonProperty("doc")]
        public DocsDoc Doc { get; set; }
        [JsonProperty("gift")]
        public GiftsLayout Gift { get; set; }
        [JsonProperty("graffiti")]
        public MessagesGraffiti Graffiti { get; set; }
        [JsonProperty("link")]
        public BaseLink Link { get; set; }
        [JsonProperty("market")]
        public MarketMarketItem Market { get; set; }
        [JsonProperty("market_market_album")]
        public MarketMarketAlbum MarketMarketAlbum { get; set; }
        [JsonProperty("photo")]
        public PhotosPhoto Photo { get; set; }
        [JsonProperty("sticker")]
        public BaseSticker Sticker { get; set; }
        [JsonProperty("type")]
        public MessagesMessageAttachmentType Type { get; set; }
        [JsonProperty("video")]
        public VideoVideo Video { get; set; }
        [JsonProperty("wall")]
        public WallWallpostFull Wall { get; set; }
        [JsonProperty("wall_reply")]
        public WallWallComment WallReply { get; set; }
    }
}