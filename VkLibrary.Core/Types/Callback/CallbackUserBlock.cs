using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackUserBlock
    {
        [JsonProperty("admin_id")]
        public int AdminId { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("unblock_date")]
        public int UnblockDate { get; set; }
        [JsonProperty("reason")]
        public int Reason { get; set; }
        [JsonProperty("comment")]
        public String Comment { get; set; }
    }
}