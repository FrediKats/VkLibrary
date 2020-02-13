using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Account
{
    public class AccountUserSettingsInterests
    {
        [JsonProperty("activities")]
        public AccountUserSettingsInterest Activities { get; set; }
        [JsonProperty("interests")]
        public AccountUserSettingsInterest Interests { get; set; }
        [JsonProperty("music")]
        public AccountUserSettingsInterest Music { get; set; }
        [JsonProperty("tv")]
        public AccountUserSettingsInterest Tv { get; set; }
        [JsonProperty("movies")]
        public AccountUserSettingsInterest Movies { get; set; }
        [JsonProperty("books")]
        public AccountUserSettingsInterest Books { get; set; }
        [JsonProperty("games")]
        public AccountUserSettingsInterest Games { get; set; }
        [JsonProperty("quotes")]
        public AccountUserSettingsInterest Quotes { get; set; }
        [JsonProperty("about")]
        public AccountUserSettingsInterest About { get; set; }
    }
}