using System;
using Newtonsoft.Json;

namespace VkLib.Types.Market 
{
    public class MarketAlbum
    {
        /// <summary>
        /// Market album ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Date when album has been updated last time in Unixtime
        /// </summary>
        [JsonProperty("updated_time")]
        public int? UpdatedTime { get; set; }

        /// <summary>
        /// Items number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo")]
        public Photo Photo { get; set; }

        /// <summary>
        /// Market album title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Market album owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

    }
}
