using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class AdsTargetGroup
    {
        ///<summary>
        /// Audience
        ///</summary>
        [JsonProperty("audience_count")]
        public int AudienceCount { get; set; }

        ///<summary>
        /// Site domain
        ///</summary>
        [JsonProperty("domain")]
        public String Domain { get; set; }

        ///<summary>
        /// Group ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Number of days for user to be in group
        ///</summary>
        [JsonProperty("lifetime")]
        public int Lifetime { get; set; }

        ///<summary>
        /// Group name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// Pixel code
        ///</summary>
        [JsonProperty("pixel")]
        public String Pixel { get; set; }
    }
}