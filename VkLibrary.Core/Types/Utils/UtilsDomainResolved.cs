using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Utils
{
    public class UtilsDomainResolved
    {
        ///<summary>
        /// Object ID
        ///</summary>
        [JsonProperty("object_id")]
        public int ObjectId { get; set; }
        [JsonProperty("type")]
        public UtilsDomainResolvedType Type { get; set; }
    }
}