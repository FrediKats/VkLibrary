using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Widgets
{
    /// <summary>
    /// API WidgetLikes object.
    /// </summary>
    public class WidgetLikes
    {
        /// <summary>
        /// Likes number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}