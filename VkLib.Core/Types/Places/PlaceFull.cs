using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Places 
{
    public class PlaceFull
    {
        /// <summary>
        /// Place address
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Place ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("city")]
        public int? City { get; set; }

        /// <summary>
        /// Date of the place creation in Unixtime
        /// </summary>
        [JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("country")]
        public int? Country { get; set; }

        /// <summary>
        /// URL of the place's icon
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Checkins number
        /// </summary>
        [JsonProperty("checkins")]
        public int? Checkins { get; set; }

        /// <summary>
        /// Place longitude
        /// </summary>
        [JsonProperty("longitude")]
        public uint? Longitude { get; set; }

        /// <summary>
        /// Distance to the place
        /// </summary>
        [JsonProperty("distance")]
        public int? Distance { get; set; }

        /// <summary>
        /// Place type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// URL of the community's photo
        /// </summary>
        [JsonProperty("group_photo")]
        public string GroupPhoto_ { get; set; }

        /// <summary>
        /// Community ID
        /// </summary>
        [JsonProperty("group_id")]
        public int? GroupId_ { get; set; }

        /// <summary>
        /// Place title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Place latitude
        /// </summary>
        [JsonProperty("latitude")]
        public uint? Latitude { get; set; }

    }
}
