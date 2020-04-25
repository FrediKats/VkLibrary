using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class StoriesGetV5113Response
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public StoriesFeedItem[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUser[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroup[] Groups { get; set; }
        [JsonProperty("need_upload_screen")]
        public Boolean NeedUploadScreen { get; set; }
    }
}