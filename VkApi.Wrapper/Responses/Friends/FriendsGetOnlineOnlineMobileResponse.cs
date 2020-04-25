using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class FriendsGetOnlineOnlineMobileResponse
    {
        [JsonProperty("online")]
        public int[] Online { get; set; }
        [JsonProperty("online_mobile")]
        public int[] OnlineMobile { get; set; }
    }
}