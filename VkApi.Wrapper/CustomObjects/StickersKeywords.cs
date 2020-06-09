using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Objects;

namespace VkApi.Wrapper.CustomObjects
{
    public class StickersKeywords
    {
        [JsonProperty("words")]
        public String[] Words { get; set; }

        [JsonProperty("user_stickers")]
        public BaseSticker[] UserStickers { get; set; }

        [JsonProperty("promoted_stickers")]
        public BaseSticker[] PromotedStickers { get; set; }
    }
}