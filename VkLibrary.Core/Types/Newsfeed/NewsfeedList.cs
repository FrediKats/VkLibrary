using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Newsfeed
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