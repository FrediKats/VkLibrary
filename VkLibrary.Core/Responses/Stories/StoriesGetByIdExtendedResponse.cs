using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Stories;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Responses.Stories
{
    public class StoriesGetByIdExtendedResponse
    {
        ///<summary>
        /// Stories count
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public StoriesStory[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroupFull[] Groups { get; set; }
    }
}