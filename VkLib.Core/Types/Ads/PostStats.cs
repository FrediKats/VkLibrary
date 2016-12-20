using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class PostStats : VkLib.Types.Stats.WallpostStat
    {
        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("ad_id")]
        public int? AdId_ { get; set; }

    }
}
