using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Wall 
{
    public class WallpostAttachment
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("market")]
        public VkLib.Types.Market.MarketItem Market { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("graffiti")]
        public VkLib.Types.Wall.Graffiti Graffiti { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("note")]
        public VkLib.Types.Wall.AttachedNote Note { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("audio")]
        public VkLib.Types.Audio.AudioFull Audio { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("video")]
        public VkLib.Types.Video.Video Video { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("link")]
        public VkLib.Types.Base.Link Link { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("app")]
        public VkLib.Types.Wall.AppPost App { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("market_market_album")]
        public VkLib.Types.Market.MarketAlbum MarketMarketAlbum { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("poll")]
        public VkLib.Types.Polls.Poll Poll { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("posted_photo")]
        public VkLib.Types.Wall.PostedPhoto PostedPhoto { get; set; }

        /// <summary>
        /// Attachment type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("page")]
        public VkLib.Types.Pages.WikipageFull Page { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photos_list")]
        public IEnumerable<string> PhotosList { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("album")]
        public VkLib.Types.Photos.PhotoAlbum Album { get; set; }

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
