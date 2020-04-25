using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class NewsfeedGetBannedExtendedResponse
    {
        [JsonProperty("groups")]
        public UsersUserFull[] Groups { get; set; }
        [JsonProperty("profiles")]
        public GroupsGroupFull[] Profiles { get; set; }
    }
}