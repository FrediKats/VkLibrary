using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Leads
{
    /// <summary>
    /// API MetricHitResponse.
    /// </summary>
    public class MetricHitResponse
    {
        /// <summary>
        /// Redirect link
        /// </summary>
        [JsonProperty("redirect_link")]
        public string RedirectLink { get; set; }

        /// <summary>
        /// Information whether request has been processed successfully
        /// </summary>
        [JsonProperty("result")]
        public bool? Result { get; set; }
    }
}