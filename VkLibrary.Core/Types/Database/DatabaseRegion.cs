using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Database
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