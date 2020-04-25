using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MarketMarketItem
    {
        ///<summary>
        /// Access key for the market item
        ///</summary>
        [JsonProperty("access_key")]
        public String AccessKey { get; set; }
        [JsonProperty("availability")]
        public MarketMarketItemAvailability Availability { get; set; }

        ///<summary>
        /// Title for button for url
        ///</summary>
        [JsonProperty("button_title")]
        public String ButtonTitle { get; set; }
        [JsonProperty("category")]
        public MarketMarketCategory Category { get; set; }

        ///<summary>
        /// Date when the item has been created in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Item description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }
        [JsonProperty("external_id")]
        public String ExternalId { get; set; }

        ///<summary>
        /// Item ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("is_favorite")]
        public Boolean IsFavorite { get; set; }

        ///<summary>
        /// Item owner's ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("price")]
        public MarketPrice Price { get; set; }

        ///<summary>
        /// URL of the preview image
        ///</summary>
        [JsonProperty("thumb_photo")]
        public String ThumbPhoto { get; set; }

        ///<summary>
        /// Item title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// URL to item
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
        [JsonProperty("variants_grouping_id")]
        public int VariantsGroupingId { get; set; }
        [JsonProperty("is_main_variant")]
        public Boolean IsMainVariant { get; set; }
    }
}