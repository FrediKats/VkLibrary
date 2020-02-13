using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Apps;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Types.Search
{
    public class SearchHint
    {
        [JsonProperty("app")]
        public AppsApp App { get; set; }

        ///<summary>
        /// Object description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// Information whether the object has been found globally
        ///</summary>
        [JsonProperty("global")]
        public int Global { get; set; }
        [JsonProperty("group")]
        public GroupsGroup Group { get; set; }
        [JsonProperty("profile")]
        public UsersUserMin Profile { get; set; }
        [JsonProperty("section")]
        public SearchHintSection Section { get; set; }
        [JsonProperty("type")]
        public SearchHintType Type { get; set; }
    }
}