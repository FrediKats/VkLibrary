using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class TargetGroup
    {
        /// <summary>
        /// Group name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Group ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Pixel code
        /// </summary>
        [JsonProperty("pixel")]
        public string Pixel { get; set; }

        /// <summary>
        /// Audience
        /// </summary>
        [JsonProperty("audience_count")]
        public int? AudienceCount_ { get; set; }

        /// <summary>
        /// Site domain
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Number of days for user to be in group
        /// </summary>
        [JsonProperty("lifetime")]
        public int? Lifetime { get; set; }

    }
}
