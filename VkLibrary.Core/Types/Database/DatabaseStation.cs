using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class DatabaseStation
    {
        ///<summary>
        /// City ID
        ///</summary>
        [JsonProperty("city_id")]
        public int CityId { get; set; }

        ///<summary>
        /// Hex color code without #
        ///</summary>
        [JsonProperty("color")]
        public String Color { get; set; }

        ///<summary>
        /// Station ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Station name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}