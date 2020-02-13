using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Database
{
    public class DatabaseFaculty
    {
        ///<summary>
        /// Faculty ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Faculty title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}