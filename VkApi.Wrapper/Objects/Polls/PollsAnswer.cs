using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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