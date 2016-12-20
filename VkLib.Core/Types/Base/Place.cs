using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class Place
    {
        /// <summary>
        /// Place address
        /// </summary>
        [JsonProperty("address")]
        public string Address_ { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        [JsonProperty("country")]
        public string Country_ { get; set; }

        /// <summary>
        /// URL of the place's icon
        /// </summary>
        [JsonProperty("icon")]
        public string Icon_ { get; set; }

        /// <summary>
        /// Checkins number
        /// </summary>
        [JsonProperty("checkins")]
        public int? Checkins_ { get; set; }

        /// <summary>
        /// Place longitude
        /// </summary>
        [JsonProperty("longitude")]
        public uint? Longitude_ { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [JsonProperty("city")]
        public string City_ { get; set; }

        /// <summary>
        /// Date of the place creation in Unixtime
        /// </summary>
        [JsonProperty("created")]
        public int? Created_ { get; set; }

        /// <summary>
        /// Place latitude
        /// </summary>
        [JsonProperty("latitude")]
        public uint? Latitude_ { get; set; }

        /// <summary>
        /// Place type
        /// </summary>
        [JsonProperty("type")]
        public string Type_ { get; set; }

        /// <summary>
        /// Place title
        /// </summary>
        [JsonProperty("title")]
        public string Title_ { get; set; }

        /// <summary>
        /// Place ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

    }
}
