using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AdsStatsViewsTimes
    {
        [JsonProperty("views_ads_times_1")]
        public int ViewsAdsTimes1 { get; set; }
        [JsonProperty("views_ads_times_2")]
        public int ViewsAdsTimes2 { get; set; }
        [JsonProperty("views_ads_times_3")]
        public int ViewsAdsTimes3 { get; set; }
        [JsonProperty("views_ads_times_4")]
        public int ViewsAdsTimes4 { get; set; }
        [JsonProperty("views_ads_times_5")]
        public String ViewsAdsTimes5 { get; set; }
        [JsonProperty("views_ads_times_6")]
        public int ViewsAdsTimes6 { get; set; }
        [JsonProperty("views_ads_times_7")]
        public int ViewsAdsTimes7 { get; set; }
        [JsonProperty("views_ads_times_8")]
        public int ViewsAdsTimes8 { get; set; }
        [JsonProperty("views_ads_times_9")]
        public int ViewsAdsTimes9 { get; set; }
        [JsonProperty("views_ads_times_10")]
        public int ViewsAdsTimes10 { get; set; }
        [JsonProperty("views_ads_times_11_plus")]
        public int ViewsAdsTimes11Plus { get; set; }
    }
}