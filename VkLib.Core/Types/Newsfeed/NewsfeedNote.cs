using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Newsfeed 
{
    public class NewsfeedNote
    {
        /// <summary>
        /// Comments Number
        /// </summary>
        [JsonProperty("comments")]
        public int? Comments { get; set; }

        /// <summary>
        /// Note ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// integer
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Note title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
