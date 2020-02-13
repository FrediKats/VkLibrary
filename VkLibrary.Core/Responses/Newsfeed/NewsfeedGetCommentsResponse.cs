using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Newsfeed;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Newsfeed
{
    public class NewsfeedGetCommentsResponse
    {
        [JsonProperty("items")]
        public NewsfeedNewsfeedItem[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroupFull[] Groups { get; set; }

        ///<summary>
        /// New from value
        ///</summary>
        [JsonProperty("next_from")]
        public String NextFrom { get; set; }
    }
}