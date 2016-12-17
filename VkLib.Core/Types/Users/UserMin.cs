using System;
using Newtonsoft.Json;

namespace VkLib.Types.Users 
{
    public class UserMin
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// User first name
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// User last name
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Returns if a profile is deleted or blocked
        /// </summary>
        [JsonProperty("deactivated")]
        public string Deactivated { get; set; }

        /// <summary>
        /// Returns if a profile is hidden.
        /// </summary>
        [JsonProperty("hidden")]
        public int? Hidden { get; set; }

    }
}
