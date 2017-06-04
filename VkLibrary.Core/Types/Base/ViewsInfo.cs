using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    public class ViewsInfo
    {
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}