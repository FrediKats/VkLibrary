using System;
using Newtonsoft.Json;

namespace VkLib.Types.Users 
{
    public class UserLim
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// User name and last name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// URL of square photo of the user with 50 pixels in width
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// User name in genitive declension
        /// </summary>
        [JsonProperty("name_gen")]
        public string NameGen { get; set; }

    }
}
