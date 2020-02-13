using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseCity
    {
        ///<summary>
        /// City ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// City title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}