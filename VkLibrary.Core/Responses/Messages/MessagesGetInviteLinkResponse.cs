using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Messages
{
    public class MessagesGetInviteLinkResponse
    {
        [JsonProperty("link")]
        public String Link { get; set; }
    }
}