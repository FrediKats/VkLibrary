using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class MarketAddAlbumResponse
    {
        ///<summary>
        /// Album ID
        ///</summary>
        [JsonProperty("market_album_id")]
        public int MarketAlbumId { get; set; }
    }
}