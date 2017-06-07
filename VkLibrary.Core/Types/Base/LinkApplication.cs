using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API LinkApplication object.
    /// </summary>
    public class LinkApplication
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("store")]
        public LinkApplicationStore Store { get; set; }

        /// <summary>
        /// Application Id
        /// </summary>
        [JsonProperty("app_id")]
        public uint? AppId { get; set; }
    }
}