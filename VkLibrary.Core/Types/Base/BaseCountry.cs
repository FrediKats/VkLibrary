using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseCountry
    {
        ///<summary>
        /// Country ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Country title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}