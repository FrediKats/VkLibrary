using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Leads
{
    /// <summary>
    /// API Start object.
    /// </summary>
    public class Start
    {
        /// <summary>
        /// Session data
        /// </summary>
        [JsonProperty("vk_sid")]
        public string VkSid { get; set; }

        /// <summary>
        /// Information whether test mode is enabled
        /// </summary>
        [JsonProperty("test_mode")]
        public int? TestMode { get; set; }
    }
}