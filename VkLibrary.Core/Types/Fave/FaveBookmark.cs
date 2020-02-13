using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;
using VkApi.Wrapper.Types.Market;
using VkApi.Wrapper.Types.Video;
using VkApi.Wrapper.Types.Wall;

namespace VkApi.Wrapper.Types.Fave
{
    public class FaveBookmark
    {
        ///<summary>
        /// Timestamp, when this item was bookmarked
        ///</summary>
        [JsonProperty("added_date")]
        public int AddedDate { get; set; }
        [JsonProperty("link")]
        public BaseLink Link { get; set; }
        [JsonProperty("post")]
        public WallWallpostFull Post { get; set; }
        [JsonProperty("product")]
        public MarketMarketItem Product { get; set; }

        ///<summary>
        /// Has user seen this item
        ///</summary>
        [JsonProperty("seen")]
        public Boolean Seen { get; set; }
        [JsonProperty("tags")]
        public FaveTag[] Tags { get; set; }

        ///<summary>
        /// Item type
        ///</summary>
        [JsonProperty("type")]
        public FaveBookmarkType Type { get; set; }
        [JsonProperty("video")]
        public VideoVideo Video { get; set; }
    }
}