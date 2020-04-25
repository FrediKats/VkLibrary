using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemFriend
    {
        [JsonProperty("friends")]
        public NewsfeedItemFriendFriends Friends { get; set; }
    }
}