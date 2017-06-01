using Newtonsoft.Json;

namespace VkLib.Types.Friends
{
    public class Requests
    {
        /// <summary>
        ///     User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("mutual")]
        public RequestsMutual Mutual { get; set; }

        /// <summary>
        ///     ID of the user by whom friend has been suggested
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }
    }
}