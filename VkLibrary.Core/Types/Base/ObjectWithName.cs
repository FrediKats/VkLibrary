using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API ObjectWithName object.
    /// </summary>
    public class ObjectWithName
    {
        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Object name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}