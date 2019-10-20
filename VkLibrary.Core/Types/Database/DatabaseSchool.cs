using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
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