using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class LinkRating
    {
        /// <summary>
        /// Count of reviews
        /// </summary>
        [JsonProperty("reviews_count")]
        public int? ReviewsCount_ { get; set; }

        /// <summary>
        /// Count of stars
        /// </summary>
        [JsonProperty("stars")]
        public uint? Stars { get; set; }

    }
}
