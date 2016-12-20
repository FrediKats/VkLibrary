using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Notes 
{
    public class Note
    {
        /// <summary>
        /// Comments number
        /// </summary>
        [JsonProperty("comments")]
        public int? Comments { get; set; }

        /// <summary>
        /// Date when the note has been created in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Information whether current user can comment the note
        /// </summary>
        [JsonProperty("can_comment")]
        public int? CanComment { get; set; }

        /// <summary>
        /// Note ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Note owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Note text in wiki format
        /// </summary>
        [JsonProperty("text_wiki")]
        public string TextWiki { get; set; }

        /// <summary>
        /// Note title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// URL of the page with note preview
        /// </summary>
        [JsonProperty("view_url")]
        public string ViewUrl { get; set; }

        /// <summary>
        /// Note text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

    }
}
