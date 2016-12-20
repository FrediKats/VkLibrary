using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Board 
{
    public class TopicPoll
    {
        /// <summary>
        /// Votes number
        /// </summary>
        [JsonProperty("votes")]
        public string Votes { get; set; }

        /// <summary>
        /// Information whether the poll is closed
        /// </summary>
        [JsonProperty("is_closed")]
        public int? IsClosed_ { get; set; }

        /// <summary>
        /// Poll owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId_ { get; set; }

        /// <summary>
        /// Poll ID
        /// </summary>
        [JsonProperty("poll_id")]
        public int? PollId_ { get; set; }

        /// <summary>
        /// Current user's answer ID
        /// </summary>
        [JsonProperty("answer_id")]
        public int? AnswerId_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("answers")]
        public IEnumerable<VkLib.Types.Polls.Answer> Answers { get; set; }

        /// <summary>
        /// Date when poll has been created in Unixtime
        /// </summary>
        [JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Poll question
        /// </summary>
        [JsonProperty("question")]
        public string Question { get; set; }

    }
}
