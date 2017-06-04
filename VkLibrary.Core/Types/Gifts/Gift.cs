using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Gifts
{
    public class Gift
    {
        /// <summary>
        /// Date when gist has been sent in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("gift")]
        public Layout GiftLayout { get; set; }

        /// <summary>
        /// Gift ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Hash
        /// </summary>
        [JsonProperty("gift_hash")]
        public string GiftHash { get; set; }

        /// <summary>
        /// Gift privacy
        /// </summary>
        [JsonProperty("privacy")]
        public int? Privacy { get; set; }

        /// <summary>
        /// Gift sender ID
        /// </summary>
        [JsonProperty("from_id")]
        public int? FromId { get; set; }
    }
}