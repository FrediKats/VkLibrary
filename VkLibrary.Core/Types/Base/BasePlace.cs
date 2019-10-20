using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class BasePlace
    {
        ///<summary>
        /// Place address
        ///</summary>
        [JsonProperty("address")]
        public String Address { get; set; }

        ///<summary>
        /// Checkins number
        ///</summary>
        [JsonProperty("checkins")]
        public int Checkins { get; set; }

        ///<summary>
        /// City name
        ///</summary>
        [JsonProperty("city")]
        public String City { get; set; }

        ///<summary>
        /// Country name
        ///</summary>
        [JsonProperty("country")]
        public String Country { get; set; }

        ///<summary>
        /// Date of the place creation in Unixtime
        ///</summary>
        [JsonProperty("created")]
        public int Created { get; set; }

        ///<summary>
        /// URL of the place's icon
        ///</summary>
        [JsonProperty("icon")]
        public String Icon { get; set; }

        ///<summary>
        /// Place ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Place latitude
        ///</summary>
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        ///<summary>
        /// Place longitude
        ///</summary>
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        ///<summary>
        /// Place title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Place type
        ///</summary>
        [JsonProperty("type")]
        public String Type { get; set; }
    }
}