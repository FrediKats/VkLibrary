using Newtonsoft.Json;

namespace VkLib.Types.Groups
{
    public class ContactsItem
    {
        /// <summary>
        ///     Contact phone
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        ///     Contact email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        ///     User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        ///     Contact description
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }
    }
}