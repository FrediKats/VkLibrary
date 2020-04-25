using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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