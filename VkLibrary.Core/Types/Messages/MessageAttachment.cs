using Newtonsoft.Json;
using VkLibrary.Core.Types.Audio;
using VkLibrary.Core.Types.Base;
using VkLibrary.Core.Types.Docs;
using VkLibrary.Core.Types.Gifts;
using VkLibrary.Core.Types.Market;
using VkLibrary.Core.Types.Photos;
using VkLibrary.Core.Types.Wall;

namespace VkLibrary.Core.Types.Messages
{
    /// <summary>
    /// API MessageAttachment object.
    /// </summary>
    public class MessageAttachment
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sticker")]
        public Sticker Sticker { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("wall")]
        public WallpostAttached Wall { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("audio")]
        public AudioFull Audio { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("wall_reply")]
        public WallComment WallReply { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("video")]
        public Video.Video Video { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("link")]
        public Link Link { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("market_market_album")]
        public MarketAlbum MarketMarketAlbum { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("gift")]
        public Layout Gift { get; set; }

        /// <summary>
        /// Attachment type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo")]
        public Photo Photo { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("market")]
        public MarketItem Market { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("doc")]
        public Doc Doc { get; set; }
    }
}