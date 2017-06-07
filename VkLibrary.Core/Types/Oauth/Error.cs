using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Oauth
{
    /// <summary>
    /// API Error object.
    /// </summary>
    public class Error
    {
        /// <summary>
        /// URI for validation
        /// </summary>
        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Error type
        /// </summary>
        [JsonProperty("error")]
        public string ErrorString { get; set; }

        /// <summary>
        /// Error description
        /// </summary>
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}