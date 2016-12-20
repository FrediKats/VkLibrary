using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Polls 
{
    public class Poll
    {
        /// <summary>
        /// Poll ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// Information whether the pole is anonymous
        /// </summary>
        [JsonProperty("anonymous")]
        public int? Anonymous_ { get; set; }

        /// <summary>
        /// Votes number
        /// </summary>
        [JsonProperty("votes")]
        public string Votes_ { get; set; }

        /// <summary>
        /// Poll owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("answers")]
        public IEnumerable<VkLib.Types.Polls.Answer> Answers_ { get; set; }

        /// <summary>
        /// Date when poll has been created in Unixtime
        /// </summary>
        [JsonProperty("created")]
        public int? Created_ { get; set; }

        /// <summary>
        /// Poll question
        /// </summary>
        [JsonProperty("question")]
        public string Question_ { get; set; }

        /// <summary>
        /// Current user's answer ID
        /// </summary>
        [JsonProperty("answer_id")]
        public int? AnswerId { get; set; }

    }
}
