using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Database
{
    public class DatabaseSchool
    {
        ///<summary>
        /// School ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// School title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}