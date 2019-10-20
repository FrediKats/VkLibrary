using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class FriendsGetOnlineOnlineMobileResponse
    {
        [JsonProperty("online")]
        public int[] Online { get; set; }
        [JsonProperty("online_mobile")]
        public int[] OnlineMobile { get; set; }
    }
}