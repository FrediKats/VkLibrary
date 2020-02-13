using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Messages
{
    public class MessagesKeyboardButton
    {
        [JsonProperty("action")]
        public MessagesKeyboardButtonAction Action { get; set; }

        ///<summary>
        /// Button color
        ///</summary>
        [JsonProperty("color")]
        public String Color { get; set; }
    }
}