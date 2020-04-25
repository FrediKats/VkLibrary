using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class DatabaseRegion
    {
        ///<summary>
        /// Region ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Region title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}