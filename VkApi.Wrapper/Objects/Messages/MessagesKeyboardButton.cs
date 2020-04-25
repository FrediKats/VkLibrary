using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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