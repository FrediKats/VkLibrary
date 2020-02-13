using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
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