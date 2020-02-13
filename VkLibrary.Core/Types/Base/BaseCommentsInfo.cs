using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseCommentsInfo
    {
        ///<summary>
        /// Information whether current user can comment the post
        ///</summary>
        [JsonProperty("can_post")]
        public int CanPost { get; set; }

        ///<summary>
        /// Comments number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// Information whether groups can comment the post
        ///</summary>
        [JsonProperty("groups_can_post")]
        public Boolean GroupsCanPost { get; set; }
    }
}