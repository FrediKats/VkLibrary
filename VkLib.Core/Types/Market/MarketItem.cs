using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Market 
{
    public class MarketItem
    {
        /// <summary>
        /// Information whether the item is available
        /// </summary>
        [JsonProperty("availability")]
        public int? Availability { get; set; }

        /// <summary>
        /// URL of the preview image
        /// </summary>
        [JsonProperty("thumb_photo")]
        public string ThumbPhoto_ { get; set; }

        /// <summary>
        /// Date when the item has been created in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Item ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("price")]
        public VkLib.Types.Market.Price Price { get; set; }

        /// <summary>
        /// Item owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("category")]
        public VkLib.Types.Market.MarketCategory Category { get; set; }

        /// <summary>
        /// Item description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Item title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
