using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Places 
{
    public class Checkin
    {
        /// <summary>
        /// Date when the checkin has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date_ { get; set; }

        /// <summary>
        /// Place latitude
        /// </summary>
        [JsonProperty("latitude")]
        public uint? Latitude_ { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("text")]
        public string Text_ { get; set; }

        /// <summary>
        /// URL of the place's icon
        /// </summary>
        [JsonProperty("place_icon")]
        public string PlaceIcon { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Distance to the place
        /// </summary>
        [JsonProperty("distance")]
        public int? Distance_ { get; set; }

        /// <summary>
        /// Place longitude
        /// </summary>
        [JsonProperty("longitude")]
        public uint? Longitude_ { get; set; }

        /// <summary>
        /// Place title
        /// </summary>
        [JsonProperty("place_title")]
        public string PlaceTitle { get; set; }

        /// <summary>
        /// Place type
        /// </summary>
        [JsonProperty("place_type")]
        public string PlaceType { get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("place_city")]
        public int? PlaceCity { get; set; }

        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("place_country")]
        public int? PlaceCountry { get; set; }

        /// <summary>
        /// Place ID
        /// </summary>
        [JsonProperty("place_id")]
        public int? PlaceId { get; set; }

        /// <summary>
        /// Checkin ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

    }
}
