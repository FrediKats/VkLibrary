using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Widgets
{
    public class WidgetsWidgetLikes
    {
        ///<summary>
        /// Likes number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}