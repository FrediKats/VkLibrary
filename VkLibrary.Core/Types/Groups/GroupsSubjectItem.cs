using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsSubjectItem
    {
        ///<summary>
        /// Subject ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Subject title
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}