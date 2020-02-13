using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackUserUnblock
    {
        [JsonProperty("admin_id")]
        public int AdminId { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("by_end_date")]
        public int ByEndDate { get; set; }
    }
}