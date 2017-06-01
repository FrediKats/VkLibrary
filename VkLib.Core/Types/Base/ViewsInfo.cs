using Newtonsoft.Json;

namespace VkLib.Types.Base
{
    public class ViewsInfo
    {
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}