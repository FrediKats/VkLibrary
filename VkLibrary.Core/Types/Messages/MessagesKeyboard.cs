using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class MessagesKeyboard
    {
        ///<summary>
        /// Community or bot, which set this keyboard
        ///</summary>
        [JsonProperty("author_id")]
        public int AuthorId { get; set; }
        [JsonProperty("buttons")]
        public MessagesKeyboardButton[][] Buttons { get; set; }

        ///<summary>
        /// Should this keyboard disappear on first use
        ///</summary>
        [JsonProperty("one_time")]
        public Boolean OneTime { get; set; }
        [JsonProperty("inline")]
        public Boolean Inline { get; set; }
    }
}