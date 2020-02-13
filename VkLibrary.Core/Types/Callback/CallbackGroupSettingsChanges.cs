using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackGroupSettingsChanges
    {
        [JsonProperty("title")]
        public String Title { get; set; }
        [JsonProperty("description")]
        public String Description { get; set; }
        [JsonProperty("access")]
        public GroupsGroupIsClosed Access { get; set; }
        [JsonProperty("screen_name")]
        public String ScreenName { get; set; }
        [JsonProperty("public_category")]
        public int PublicCategory { get; set; }
        [JsonProperty("public_subcategory")]
        public int PublicSubcategory { get; set; }
        [JsonProperty("age_limits")]
        public GroupsGroupFullAgeLimits AgeLimits { get; set; }
        [JsonProperty("website")]
        public String Website { get; set; }
        [JsonProperty("enable_status_default")]
        public GroupsGroupWall EnableStatusDefault { get; set; }
        [JsonProperty("enable_audio")]
        public GroupsGroupAudio EnableAudio { get; set; }
        [JsonProperty("enable_video")]
        public GroupsGroupVideo EnableVideo { get; set; }
        [JsonProperty("enable_photo")]
        public GroupsGroupPhotos EnablePhoto { get; set; }
        [JsonProperty("enable_market")]
        public CallbackGroupMarket EnableMarket { get; set; }
    }
}