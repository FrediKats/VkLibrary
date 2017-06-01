using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Audio;
using VkLib.Types.Base;
using VkLib.Types.Docs;
using VkLib.Types.Market;
using VkLib.Types.Pages;
using VkLib.Types.Photos;
using VkLib.Types.Polls;

namespace VkLib.Types.Wall
{
    public class WallpostAttachment
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("market")]
        public MarketItem Market { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("graffiti")]
        public Graffiti Graffiti { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("note")]
        public AttachedNote Note { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("audio")]
        public AudioFull Audio { get; set; }

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
        [JsonProperty("app")]
        public AppPost App { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("market_market_album")]
        public MarketAlbum MarketMarketAlbum { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("poll")]
        public Poll Poll { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("posted_photo")]
        public PostedPhoto PostedPhoto { get; set; }

        /// <summary>
        ///     Attachment type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("page")]
        public WikipageFull Page { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("photos_list")]
        public IEnumerable<string> PhotosList { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("album")]
        public PhotoAlbum Album { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("photo")]
        public Photo Photo { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("doc")]
        public Doc Doc { get; set; }
    }
}