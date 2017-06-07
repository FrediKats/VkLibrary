using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API LinkApplicationStore object.
    /// </summary>
    public class LinkApplicationStore
    {
        /// <summary>
        /// Store Id
        /// </summary>
        [JsonProperty("id")]
        public uint? Id { get; set; }

        /// <summary>
        /// Store name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}