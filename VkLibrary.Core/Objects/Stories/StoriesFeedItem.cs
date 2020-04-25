using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class StoriesFeedItem
    {
        ///<summary>
        /// Type of Feed Item
        ///</summary>
        [JsonProperty("type")]
        public String Type { get; set; }

        ///<summary>
        /// Author stories
        ///</summary>
        [JsonProperty("stories")]
        public StoriesStory[] Stories { get; set; }

        ///<summary>
        /// Grouped stories of various authors (for types community_grouped_stories/app_grouped_stories type)
        ///</summary>
        [JsonProperty("grouped")]
        public StoriesFeedItem[] Grouped { get; set; }

        ///<summary>
        /// App, which stories has been grouped (for type app_grouped_stories)
        ///</summary>
        [JsonProperty("app")]
        public AppsAppMin App { get; set; }

        ///<summary>
        /// Additional data for promo stories (for type promo_stories)
        ///</summary>
        [JsonProperty("promo_data")]
        public StoriesPromoBlock PromoData { get; set; }
    }
}