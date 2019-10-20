using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class GroupsCover
    {
        ///<summary>
        /// Information whether cover is enabled
        ///</summary>
        [JsonProperty("enabled")]
        public int Enabled { get; set; }
        [JsonProperty("images")]
        public BaseImage[] Images { get; set; }
    }
}