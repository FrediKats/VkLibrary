using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class DocsDocTypes
    {
        ///<summary>
        /// Number of docs
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// Doc type ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Doc type title
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}