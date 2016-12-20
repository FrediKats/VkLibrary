using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Market 
{
    public class MarketItemFull : VkLib.Types.Market.MarketItem
    {
        /// <summary>
        /// Views number
        /// </summary>
        [JsonProperty("views_count")]
        public int? ViewsCount { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Base.Likes Likes { get; set; }

        /// <summary>
        /// Information whether current use can comment the item
        /// </summary>
        [JsonProperty("can_comment")]
        public int? CanComment { get; set; }

        /// <summary>
        /// Information whether current use can repost the item
        /// </summary>
        [JsonProperty("can_repost")]
        public int? CanRepost { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photos")]
        public IEnumerable<VkLib.Types.Photos.Photo> Photos { get; set; }

    }
}
