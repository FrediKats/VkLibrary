using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class StoriesClickableStickers
    {
        [JsonProperty("clickable_stickers")]
        public StoriesClickableSticker[] ClickableStickers { get; set; }
        [JsonProperty("original_height")]
        public int OriginalHeight { get; set; }
        [JsonProperty("original_width")]
        public int OriginalWidth { get; set; }
    }
}