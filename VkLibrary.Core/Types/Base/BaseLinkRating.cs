using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class BaseLinkRating
    {
        ///<summary>
        /// Count of reviews
        ///</summary>
        [JsonProperty("reviews_count")]
        public int ReviewsCount { get; set; }

        ///<summary>
        /// Count of stars
        ///</summary>
        [JsonProperty("stars")]
        public double Stars { get; set; }
    }
}