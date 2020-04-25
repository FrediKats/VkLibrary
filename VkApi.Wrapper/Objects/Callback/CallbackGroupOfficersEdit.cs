using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class CallbackGroupOfficersEdit
    {
        [JsonProperty("admin_id")]
        public int AdminId { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("level_old")]
        public CallbackGroupOfficerRole LevelOld { get; set; }
        [JsonProperty("level_new")]
        public CallbackGroupOfficerRole LevelNew { get; set; }
    }
}