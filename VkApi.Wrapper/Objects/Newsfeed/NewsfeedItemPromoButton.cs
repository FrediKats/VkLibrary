using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemPromoButton : NewsfeedItemBase
    {
        [JsonProperty("text")]
        public String Text { get; set; }
        [JsonProperty("title")]
        public String Title { get; set; }
        [JsonProperty("action")]
        public NewsfeedItemPromoButtonAction Action { get; set; }
        [JsonProperty("images")]
        public NewsfeedItemPromoButtonImage[] Images { get; set; }
        [JsonProperty("track_code")]
        public String TrackCode { get; set; }
    }
}