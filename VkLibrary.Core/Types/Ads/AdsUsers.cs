using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsUsers
    {
        [JsonProperty("accesses")]
        public AdsAccesses[] Accesses { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}