using Newtonsoft.Json;
using VkApi.Wrapper.Types.Widgets;

namespace VkApi.Wrapper.Responses.Widgets
{
    public class WidgetsGetCommentsResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("posts")]
        public WidgetsWidgetComment[] Posts { get; set; }
    }
}