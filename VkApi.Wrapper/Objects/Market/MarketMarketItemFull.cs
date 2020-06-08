using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MarketMarketItemFull : MarketMarketItem
    {
        [JsonProperty("albums_ids")]
        public int[] AlbumsIds { get; set; }
        [JsonProperty("photos")]
        public PhotosPhoto[] Photos { get; set; }

        ///<summary>
        /// Information whether current use can comment the item
        ///</summary>
        [JsonProperty("can_comment")]
        public int CanComment { get; set; }

        ///<summary>
        /// Information whether current use can repost the item
        ///</summary>
        [JsonProperty("can_repost")]
        public int CanRepost { get; set; }
        [JsonProperty("likes")]
        public BaseLikes Likes { get; set; }
        [JsonProperty("reposts")]
        public BaseRepostsInfo Reposts { get; set; }

        ///<summary>
        /// Views number
        ///</summary>
        [JsonProperty("views_count")]
        public int ViewsCount { get; set; }
    }
}