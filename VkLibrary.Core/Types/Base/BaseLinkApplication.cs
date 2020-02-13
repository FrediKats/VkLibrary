using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseLinkApplication
    {
        ///<summary>
        /// Application Id
        ///</summary>
        [JsonProperty("app_id")]
        public double AppId { get; set; }
        [JsonProperty("store")]
        public BaseLinkApplicationStore Store { get; set; }
    }
}