using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Friends
{
    public class FriendsFriendsList
    {
        ///<summary>
        /// List ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// List title
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}