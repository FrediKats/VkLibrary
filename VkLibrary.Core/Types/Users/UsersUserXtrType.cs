using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UsersUserXtrType
    {
        [JsonProperty("type")]
        public UsersUserType Type { get; set; }
    }
}