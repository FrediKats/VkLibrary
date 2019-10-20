using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class FriendsFriendsList
    {
        ///<summary>
        /// List ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// List title
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}