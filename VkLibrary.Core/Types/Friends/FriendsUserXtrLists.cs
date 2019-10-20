using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class FriendsUserXtrLists
    {
        [JsonProperty("lists")]
        public int[] Lists { get; set; }
    }
}