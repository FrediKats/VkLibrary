using Newtonsoft.Json;

namespace VkLib.Types.Ads
{
    public class LinkStatus
    {
        /// <summary>
        ///     URL
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        ///     Link status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Reject reason
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}