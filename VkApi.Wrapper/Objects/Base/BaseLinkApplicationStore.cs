using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BaseLinkApplicationStore
    {
        ///<summary>
        /// Store Id
        ///</summary>
        [JsonProperty("id")]
        public double Id { get; set; }

        ///<summary>
        /// Store name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}