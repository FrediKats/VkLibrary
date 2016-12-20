using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Polls 
{
    public class Answer
    {
        /// <summary>
        /// Answer rate in percents
        /// </summary>
        [JsonProperty("rate")]
        public uint? Rate_ { get; set; }

        /// <summary>
        /// Answer ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// Answer text
        /// </summary>
        [JsonProperty("text")]
        public string Text_ { get; set; }

        /// <summary>
        /// Votes number
        /// </summary>
        [JsonProperty("votes")]
        public int? Votes_ { get; set; }

    }
}
