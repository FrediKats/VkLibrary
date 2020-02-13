using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Polls
{
    public class PollsAnswer
    {
        ///<summary>
        /// Answer ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Answer rate in percents
        ///</summary>
        [JsonProperty("rate")]
        public double Rate { get; set; }

        ///<summary>
        /// Answer text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// Votes number
        ///</summary>
        [JsonProperty("votes")]
        public int Votes { get; set; }
    }
}