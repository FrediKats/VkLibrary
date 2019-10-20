using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Additional data for promo stories
    ///</summary>
    public class StoriesPromoBlock
    {
        ///<summary>
        /// Promo story title
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// RL of square photo of the story with 50 pixels in width
        ///</summary>
        [JsonProperty("photo_50")]
        public String Photo50 { get; set; }

        ///<summary>
        /// RL of square photo of the story with 100 pixels in width
        ///</summary>
        [JsonProperty("photo_100")]
        public String Photo100 { get; set; }

        ///<summary>
        /// Hide animation for promo story
        ///</summary>
        [JsonProperty("not_animated")]
        public Boolean NotAnimated { get; set; }
    }
}