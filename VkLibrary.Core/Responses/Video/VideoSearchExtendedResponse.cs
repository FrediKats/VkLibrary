using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Users;
using VkApi.Wrapper.Types.Video;

namespace VkApi.Wrapper.Responses.Video
{
    public class VideoSearchExtendedResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public VideoVideo[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUserMin[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroupFull[] Groups { get; set; }
    }
}