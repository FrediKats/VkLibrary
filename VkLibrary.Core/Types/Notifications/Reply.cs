using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Notifications
{
    /// <summary>
    /// API Reply object.
    /// </summary>
    public class Reply
    {
        /// <summary>
        /// Date when the reply has been created in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Reply ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Reply text
        /// </summary>
        [JsonProperty("text")]
        public int? Text { get; set; }
    }
}