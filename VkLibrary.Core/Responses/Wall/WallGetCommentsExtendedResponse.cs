using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Users;
using VkApi.Wrapper.Types.Wall;

namespace VkApi.Wrapper.Responses.Wall
{
    public class WallGetCommentsExtendedResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public WallWallComment[] Items { get; set; }
        [JsonProperty("show_reply_button")]
        public Boolean ShowReplyButton { get; set; }

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
        [JsonProperty("profiles")]
        public UsersUser[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroup[] Groups { get; set; }
    }
}