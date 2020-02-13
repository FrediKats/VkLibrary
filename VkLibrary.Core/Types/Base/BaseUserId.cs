using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseUserId
    {
        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}