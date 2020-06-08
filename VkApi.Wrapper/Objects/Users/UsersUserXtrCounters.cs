using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class UsersUserXtrCounters : UsersUserFull
    {
        [JsonProperty("counters")]
        public UsersUserCounters Counters { get; set; }
    }
}