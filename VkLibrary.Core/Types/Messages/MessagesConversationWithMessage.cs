using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class MessagesConversationWithMessage
    {
        [JsonProperty("conversation")]
        public MessagesConversation Conversation { get; set; }
        [JsonProperty("last_message")]
        public MessagesMessage LastMessage { get; set; }
    }
}