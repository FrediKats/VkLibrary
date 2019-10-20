using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class PollsVoters
    {
        ///<summary>
        /// Answer ID
        ///</summary>
        [JsonProperty("answer_id")]
        public int AnswerId { get; set; }
        [JsonProperty("users")]
        public PollsVotersUsers Users { get; set; }
    }
}