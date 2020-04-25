using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class MessagesGetChatPreviewResponse
    {
        [JsonProperty("preview")]
        public MessageChatPreview Preview { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
    }
}