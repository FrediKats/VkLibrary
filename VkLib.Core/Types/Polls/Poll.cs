using System;
using Newtonsoft.Json;

namespace VkLib.Types.Polls 
{
    public class Poll
    {
        /// <summary>
        /// Poll ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Information whether the pole is anonymous
        /// </summary>
        [JsonProperty("anonymous")]
        public BoolInt Anonymous { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("answers")]
        public IEnumerable<Answer> Answers { get; set; }

        /// <summary>
        /// Current user's answer ID
        /// </summary>
        [JsonProperty("answer_id")]
        public int? AnswerId { get; set; }

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

        /// <summary>
        /// Poll owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Votes number
        /// </summary>
        [JsonProperty("votes")]
        public string Votes { get; set; }

    }
}
