using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedList
    {
        ///<summary>
        /// List ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// List title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}