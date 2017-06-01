using Newtonsoft.Json;

namespace VkLib.Types.Base
{
    public class LinkRating
    {
        /// <summary>
        ///     Count of stars
        /// </summary>
        [JsonProperty("stars")]
        public uint? Stars { get; set; }

        /// <summary>
        ///     Count of reviews
        /// </summary>
        [JsonProperty("reviews_count")]
        public int? ReviewsCount { get; set; }
    }
}