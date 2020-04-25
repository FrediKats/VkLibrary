using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class GroupsAddCallbackServerResponse
    {
        [JsonProperty("server_id")]
        public int ServerId { get; set; }
    }
}