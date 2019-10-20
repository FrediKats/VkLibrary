using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class GiftsLayout
    {
        ///<summary>
        /// Gift ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// URL of the preview image with 256 px in width
        ///</summary>
        [JsonProperty("thumb_256")]
        public String Thumb256 { get; set; }

        ///<summary>
        /// URL of the preview image with 48 px in width
        ///</summary>
        [JsonProperty("thumb_48")]
        public String Thumb48 { get; set; }

        ///<summary>
        /// URL of the preview image with 96 px in width
        ///</summary>
        [JsonProperty("thumb_96")]
        public String Thumb96 { get; set; }
    }
}