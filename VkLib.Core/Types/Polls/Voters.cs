using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Polls 
{
    public class Voters
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("users")]
        public VkLib.Types.Polls.VotersUsers Users { get; set; }

        /// <summary>
        /// Answer ID
        /// </summary>
        [JsonProperty("answer_id")]
        public int? AnswerId { get; set; }

    }
}
