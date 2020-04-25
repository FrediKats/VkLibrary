using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class WallAppPost
    {
        ///<summary>
        /// Application ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Application name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// URL of the preview image with 130 px in width
        ///</summary>
        [JsonProperty("photo_130")]
        public String Photo130 { get; set; }

        ///<summary>
        /// URL of the preview image with 604 px in width
        ///</summary>
        [JsonProperty("photo_604")]
        public String Photo604 { get; set; }
    }
}