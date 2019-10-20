using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UsersOccupation
    {
        ///<summary>
        /// ID of school, university, company group
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Name of occupation
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// Type of occupation
        ///</summary>
        [JsonProperty("type")]
        public String Type { get; set; }
    }
}