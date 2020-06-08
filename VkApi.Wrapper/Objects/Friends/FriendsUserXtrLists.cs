using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class FriendsUserXtrLists : UsersUserFull
    {
        [JsonProperty("lists")]
        public int[] Lists { get; set; }
    }
}