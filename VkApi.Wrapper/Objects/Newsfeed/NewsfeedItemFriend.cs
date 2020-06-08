using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemFriend : NewsfeedItemBase
    {
        [JsonProperty("friends")]
        public NewsfeedItemFriendFriends Friends { get; set; }
    }
}