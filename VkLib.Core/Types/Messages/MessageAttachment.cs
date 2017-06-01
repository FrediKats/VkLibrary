using Newtonsoft.Json;
using VkLib.Types.Audio;
using VkLib.Types.Base;
using VkLib.Types.Docs;
using VkLib.Types.Gifts;
using VkLib.Types.Market;
using VkLib.Types.Photos;
using VkLib.Types.Wall;

namespace VkLib.Types.Messages
{
    public class MessageAttachment
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("sticker")]
        public Sticker Sticker { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("wall")]
        public WallpostAttached Wall { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("audio")]
        public AudioFull Audio { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("wall_reply")]
        public WallComment WallReply { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("video")]
        public Video.Video Video { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("link")]
        public Link Link { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("market_market_album")]
        public MarketAlbum MarketMarketAlbum { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("gift")]
        public Layout Gift { get; set; }

        /// <summary>
        ///     Attachment type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("photo")]
        public Photo Photo { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("market")]
        public MarketItem Market { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("doc")]
        public Doc Doc { get; set; }
    }
}