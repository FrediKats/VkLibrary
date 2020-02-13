using Newtonsoft.Json;
using VkApi.Wrapper.Types.Audio;
using VkApi.Wrapper.Types.Base;
using VkApi.Wrapper.Types.Docs;
using VkApi.Wrapper.Types.Market;
using VkApi.Wrapper.Types.Pages;
using VkApi.Wrapper.Types.Photos;
using VkApi.Wrapper.Types.Video;

namespace VkApi.Wrapper.Types.Wall
{
    public class WallCommentAttachment
    {
        [JsonProperty("audio")]
        public AudioAudio Audio { get; set; }
        [JsonProperty("doc")]
        public DocsDoc Doc { get; set; }
        [JsonProperty("link")]
        public BaseLink Link { get; set; }
        [JsonProperty("market")]
        public MarketMarketItem Market { get; set; }
        [JsonProperty("market_market_album")]
        public MarketMarketAlbum MarketMarketAlbum { get; set; }
        [JsonProperty("note")]
        public WallAttachedNote Note { get; set; }
        [JsonProperty("page")]
        public PagesWikipageFull Page { get; set; }
        [JsonProperty("photo")]
        public PhotosPhoto Photo { get; set; }
        [JsonProperty("sticker")]
        public BaseSticker Sticker { get; set; }
        [JsonProperty("type")]
        public WallCommentAttachmentType Type { get; set; }
        [JsonProperty("video")]
        public VideoVideo Video { get; set; }
    }
}