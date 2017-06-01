using Newtonsoft.Json;

namespace VkLib.Types.Widgets
{
    public class WidgetLikes
    {
        /// <summary>
        ///     Likes number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}