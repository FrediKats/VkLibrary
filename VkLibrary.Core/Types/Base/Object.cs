using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API Object object.
    /// </summary>
    public class Object
    {
        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Object title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}