using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Video restriction button
    ///</summary>
    public class VideoRestrictionButton
    {
        [JsonProperty("action")]
        public String Action { get; set; }
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}