using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class DatabaseUniversity
    {
        ///<summary>
        /// University ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// University title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}