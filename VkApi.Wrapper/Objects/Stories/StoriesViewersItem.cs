using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class StoriesViewersItem
    {
        ///<summary>
        /// user has like for this object
        ///</summary>
        [JsonProperty("is_liked")]
        public Boolean IsLiked { get; set; }

        ///<summary>
        /// user id
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("user")]
        public UsersUserFull User { get; set; }
    }
}