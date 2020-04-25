using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BoardTopicPoll
    {
        ///<summary>
        /// Current user's answer ID
        ///</summary>
        [JsonProperty("answer_id")]
        public int AnswerId { get; set; }
        [JsonProperty("answers")]
        public PollsAnswer[] Answers { get; set; }

        ///<summary>
        /// Date when poll has been created in Unixtime
        ///</summary>
        [JsonProperty("created")]
        public int Created { get; set; }

        ///<summary>
        /// Information whether the poll is closed
        ///</summary>
        [JsonProperty("is_closed")]
        public int IsClosed { get; set; }

        ///<summary>
        /// Poll owner's ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// Poll ID
        ///</summary>
        [JsonProperty("poll_id")]
        public int PollId { get; set; }

        ///<summary>
        /// Poll question
        ///</summary>
        [JsonProperty("question")]
        public String Question { get; set; }

        ///<summary>
        /// Votes number
        ///</summary>
        [JsonProperty("votes")]
        public String Votes { get; set; }
    }
}