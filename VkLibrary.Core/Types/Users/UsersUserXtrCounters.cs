using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UsersUserXtrCounters
    {
        [JsonProperty("counters")]
        public UsersUserCounters Counters { get; set; }
    }
}