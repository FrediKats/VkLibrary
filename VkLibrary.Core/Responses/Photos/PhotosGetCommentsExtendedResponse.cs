using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Users;
using VkApi.Wrapper.Types.Wall;

namespace VkApi.Wrapper.Responses.Photos
{
    public class PhotosGetCommentsExtendedResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// Real offset of the comments
        ///</summary>
        [JsonProperty("real_offset")]
        public int RealOffset { get; set; }
        [JsonProperty("items")]
        public WallWallComment[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroupFull[] Groups { get; set; }
    }
}