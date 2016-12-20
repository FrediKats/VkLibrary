using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Messages 
{
    public class Dialog
    {
        /// <summary>
        /// ID of the last message read by the others
        /// </summary>
        [JsonProperty("out_read")]
        public int? OutRead { get; set; }

        /// <summary>
        /// Information whether unread messages are in the dialog
        /// </summary>
        [JsonProperty("unread")]
        public int? Unread { get; set; }

        /// <summary>
        /// ID of the last message read by current user
        /// </summary>
        [JsonProperty("in_read")]
        public int? InRead { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("message")]
        public VkLib.Types.Messages.Message Message { get; set; }

    }
}
