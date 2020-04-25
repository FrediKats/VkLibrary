using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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