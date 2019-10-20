using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class NewsfeedNewsfeedNote
    {
        ///<summary>
        /// Comments Number
        ///</summary>
        [JsonProperty("comments")]
        public int Comments { get; set; }

        ///<summary>
        /// Note ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// integer
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// Note title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}