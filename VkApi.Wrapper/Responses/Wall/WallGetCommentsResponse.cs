using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class WallGetCommentsResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public WallWallComment[] Items { get; set; }

        ///<summary>
        /// Information whether current user can comment the post
        ///</summary>
        [JsonProperty("can_post")]
        public Boolean CanPost { get; set; }

        ///<summary>
        /// Information whether groups can comment the post
        ///</summary>
        [JsonProperty("groups_can_post")]
        public Boolean GroupsCanPost { get; set; }

        ///<summary>
        /// Count of replies of current level
        ///</summary>
        [JsonProperty("current_level_count")]
        public int CurrentLevelCount { get; set; }
    }
}