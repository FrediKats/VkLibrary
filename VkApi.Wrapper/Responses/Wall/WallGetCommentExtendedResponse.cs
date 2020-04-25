using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class WallGetCommentExtendedResponse
    {
        [JsonProperty("items")]
        public WallWallComment[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUser[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroup[] Groups { get; set; }
    }
}