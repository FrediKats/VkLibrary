using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class NewsfeedItemFriend
    {
        [JsonProperty("friends")]
        public NewsfeedItemFriendFriends Friends { get; set; }
    }
}