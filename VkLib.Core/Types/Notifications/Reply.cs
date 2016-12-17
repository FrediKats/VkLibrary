using System;
using Newtonsoft.Json;

namespace VkLib.Types.Notifications 
{
    public class Reply
    {
        /// <summary>
        /// Reply ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Date when the reply has been created in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Reply text
        /// </summary>
        [JsonProperty("text")]
        public int? Text { get; set; }

    }
}
