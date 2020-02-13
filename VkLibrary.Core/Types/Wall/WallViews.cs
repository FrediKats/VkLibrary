using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Wall
{
    public class WallViews
    {
        ///<summary>
        /// Count
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}