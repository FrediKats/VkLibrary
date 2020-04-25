using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Media restrictions
    ///</summary>
    public class MediaRestriction
    {
        [JsonProperty("text")]
        public String Text { get; set; }
        [JsonProperty("title")]
        public String Title { get; set; }
        [JsonProperty("button")]
        public VideoRestrictionButton Button { get; set; }

        ///<summary>
        /// Need show restriction always or not
        ///</summary>
        [JsonProperty("always_shown")]
        public int AlwaysShown { get; set; }

        ///<summary>
        /// Need blur current video or not
        ///</summary>
        [JsonProperty("blur")]
        public int Blur { get; set; }

        ///<summary>
        /// Can play video or not
        ///</summary>
        [JsonProperty("can_play")]
        public int CanPlay { get; set; }

        ///<summary>
        /// Can preview video or not
        ///</summary>
        [JsonProperty("can_preview")]
        public int CanPreview { get; set; }
        [JsonProperty("card_icon")]
        public BaseImage[] CardIcon { get; set; }
        [JsonProperty("list_icon")]
        public BaseImage[] ListIcon { get; set; }
    }
}