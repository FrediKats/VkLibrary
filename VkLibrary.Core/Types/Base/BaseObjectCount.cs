using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseObjectCount
    {
        ///<summary>
        /// Items count
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}