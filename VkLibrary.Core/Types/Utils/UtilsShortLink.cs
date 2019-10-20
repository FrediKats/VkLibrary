using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UtilsShortLink
    {
        ///<summary>
        /// Access key for private stats
        ///</summary>
        [JsonProperty("access_key")]
        public String AccessKey { get; set; }

        ///<summary>
        /// Link key (characters after vk.cc/)
        ///</summary>
        [JsonProperty("key")]
        public String Key { get; set; }

        ///<summary>
        /// Short link URL
        ///</summary>
        [JsonProperty("short_url")]
        public String ShortUrl { get; set; }

        ///<summary>
        /// Full URL
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}