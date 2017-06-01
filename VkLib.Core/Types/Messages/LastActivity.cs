using Newtonsoft.Json;

namespace VkLib.Types.Messages
{
    public class LastActivity
    {
        /// <summary>
        ///     Time when user was online in Unixtime
        /// </summary>
        [JsonProperty("time")]
        public int? Time { get; set; }

        /// <summary>
        ///     Information whether user is online
        /// </summary>
        [JsonProperty("online")]
        public int? Online { get; set; }
    }
}