using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Friends 
{
    public class FriendsList
    {
        /// <summary>
        /// List title
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// List ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

    }
}
