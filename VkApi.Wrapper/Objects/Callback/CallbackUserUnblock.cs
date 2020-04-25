using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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