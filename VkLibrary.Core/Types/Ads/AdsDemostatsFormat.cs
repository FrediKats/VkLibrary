using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsDemostatsFormat
    {
        [JsonProperty("age")]
        public AdsStatsAge[] Age { get; set; }
        [JsonProperty("cities")]
        public AdsStatsCities[] Cities { get; set; }

        ///<summary>
        /// Day as YYYY-MM-DD
        ///</summary>
        [JsonProperty("day")]
        public String Day { get; set; }

        ///<summary>
        /// Month as YYYY-MM
        ///</summary>
        [JsonProperty("month")]
        public String Month { get; set; }

        ///<summary>
        /// 1 if period=overall
        ///</summary>
        [JsonProperty("overall")]
        public int Overall { get; set; }
        [JsonProperty("sex")]
        public AdsStatsSex[] Sex { get; set; }
        [JsonProperty("sex_age")]
        public AdsStatsSexAge[] SexAge { get; set; }
    }
}