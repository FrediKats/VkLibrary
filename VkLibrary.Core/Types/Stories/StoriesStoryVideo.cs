using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class StoriesStoryVideo
    {
        ///<summary>
        /// Information whether story is private (0 - no, 1 - yes).
        ///</summary>
        [JsonProperty("is_private")]
        public int IsPrivate { get; set; }
    }
}