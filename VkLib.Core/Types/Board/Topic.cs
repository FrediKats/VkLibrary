using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Board 
{
    public class Topic
    {
        /// <summary>
        /// Creator ID
        /// </summary>
        [JsonProperty("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Information whether the topic is closed
        /// </summary>
        [JsonProperty("is_closed")]
        public int? IsClosed { get; set; }

        /// <summary>
        /// Topic ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// ID of user who updated the topic
        /// </summary>
        [JsonProperty("updated_by")]
        public int? UpdatedBy { get; set; }

        /// <summary>
        /// Comments number
        /// </summary>
        [JsonProperty("comments")]
        public int? Comments_ { get; set; }

        /// <summary>
        /// Date when the topic has been created in Unixtime
        /// </summary>
        [JsonProperty("created")]
        public int? Created_ { get; set; }

        /// <summary>
        /// Information whether the topic is fixed
        /// </summary>
        [JsonProperty("is_fixed")]
        public int? IsFixed { get; set; }

        /// <summary>
        /// Topic title
        /// </summary>
        [JsonProperty("title")]
        public string Title_ { get; set; }

        /// <summary>
        /// Date when the topic has been updated in Unixtime
        /// </summary>
        [JsonProperty("updated")]
        public int? Updated_ { get; set; }

    }
}
