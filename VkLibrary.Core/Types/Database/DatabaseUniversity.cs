using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Database
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