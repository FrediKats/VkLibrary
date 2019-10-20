using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class MarketMarketAlbum
    {
        ///<summary>
        /// Items number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// Market album ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Market album owner's ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("photo")]
        public PhotosPhoto Photo { get; set; }

        ///<summary>
        /// Market album title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Date when album has been updated last time in Unixtime
        ///</summary>
        [JsonProperty("updated_time")]
        public int UpdatedTime { get; set; }
    }
}