using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Groups
{
    public class BanInfo
    {
        /// <summary>
        /// Administrator ID
        /// </summary>
        [JsonProperty("admin_id")]
        public int? AdminId { get; set; }

        /// <summary>
        /// Date when user has been added to blacklist in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Date when user will be removed from blacklist in Unixtime
        /// </summary>
        [JsonProperty("end_date")]
        public int? EndDate { get; set; }

        /// <summary>
        /// Comment for a ban
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Ban reason
        /// </summary>
        [JsonProperty("reason")]
        public int? Reason { get; set; }
    }
}