using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class AccountUserSettingsInterest
    {
        [JsonProperty("title")]
        public String Title { get; set; }
        [JsonProperty("value")]
        public String Value { get; set; }
    }
}