using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Wall 
{
    public class CommentAttachment
    {
        /// <summary>
        /// Attachment type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("note")]
        public VkLib.Types.Wall.AttachedNote Note { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("link")]
        public VkLib.Types.Base.Link Link { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("market_market_album")]
        public VkLib.Types.Market.MarketAlbum MarketMarketAlbum { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("market")]
        public VkLib.Types.Market.MarketItem Market { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("page")]
        public VkLib.Types.Pages.WikipageFull Page { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("video")]
        public VkLib.Types.Video.Video Video { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sticker")]
        public VkLib.Types.Base.Sticker Sticker { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("audio")]
        public VkLib.Types.Audio.AudioFull Audio { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo")]
        public VkLib.Types.Photos.Photo Photo { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("doc")]
        public VkLib.Types.Docs.Doc Doc { get; set; }

    }
}
