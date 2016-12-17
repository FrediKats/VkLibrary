using System;
using Newtonsoft.Json;

namespace VkLib.Types.Base 
{
    public class UserId
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

    }
}
