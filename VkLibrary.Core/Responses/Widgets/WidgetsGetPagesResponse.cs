using Newtonsoft.Json;
using VkApi.Wrapper.Types.Widgets;

namespace VkApi.Wrapper.Responses.Widgets
{
    public class WidgetsGetPagesResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("pages")]
        public WidgetsWidgetPage[] Pages { get; set; }
    }
}