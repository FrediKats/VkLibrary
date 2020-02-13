using Newtonsoft.Json;
using VkApi.Wrapper.Types.Ads;

namespace VkApi.Wrapper.Responses.Ads
{
    public class AdsGetCategoriesResponse
    {
        ///<summary>
        /// Old categories
        ///</summary>
        [JsonProperty("v1")]
        public AdsCategory[] V1 { get; set; }

        ///<summary>
        /// Actual categories
        ///</summary>
        [JsonProperty("v2")]
        public AdsCategory[] V2 { get; set; }
    }
}