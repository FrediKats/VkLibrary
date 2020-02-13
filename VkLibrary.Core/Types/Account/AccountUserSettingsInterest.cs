using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Account
{
    public class AccountUserSettingsInterest
    {
        [JsonProperty("title")]
        public String Title { get; set; }
        [JsonProperty("value")]
        public String Value { get; set; }
    }
}