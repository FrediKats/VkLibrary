using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemHolidayRecommendationsBlockHeader
    {
        ///<summary>
        /// Title of the header
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Subtitle of the header
        ///</summary>
        [JsonProperty("subtitle")]
        public String Subtitle { get; set; }
        [JsonProperty("image")]
        public BaseImage[] Image { get; set; }
        [JsonProperty("action")]
        public BaseLinkButtonAction Action { get; set; }
    }
}