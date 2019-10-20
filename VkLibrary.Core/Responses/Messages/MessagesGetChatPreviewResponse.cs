using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class MessagesGetChatPreviewResponse
    {
        [JsonProperty("preview")]
        public MessageChatPreview Preview { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
    }
}