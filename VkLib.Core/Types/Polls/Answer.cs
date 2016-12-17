using System;
using Newtonsoft.Json;

namespace VkLib.Types.Polls 
{
    public class Answer
    {
        /// <summary>
        /// Answer ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Votes number
        /// </summary>
        [JsonProperty("votes")]
        public int? Votes { get; set; }

        /// <summary>
        /// Answer rate in percents
        /// </summary>
        [JsonProperty("rate")]
        public uint? Rate { get; set; }

        /// <summary>
        /// Answer text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

    }
}
