using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Description of the action, that should be performed on button click
    ///</summary>
    public class MessagesKeyboardButtonAction
    {
        ///<summary>
        /// Fragment value in app link like vk.com/app{app_id}_-654321#hash
        ///</summary>
        [JsonProperty("app_id")]
        public int AppId { get; set; }

        ///<summary>
        /// Fragment value in app link like vk.com/app123456_-654321#{hash}
        ///</summary>
        [JsonProperty("hash")]
        public String Hash { get; set; }

        ///<summary>
        /// Label for button
        ///</summary>
        [JsonProperty("label")]
        public String Label { get; set; }

        ///<summary>
        /// Fragment value in app link like vk.com/app123456_{owner_id}#hash
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// Additional data sent along with message for developer convenience
        ///</summary>
        [JsonProperty("payload")]
        public String Payload { get; set; }

        ///<summary>
        /// Button type
        ///</summary>
        [JsonProperty("type")]
        public String Type { get; set; }
    }
}