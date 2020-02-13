using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Stats
{
    ///<summary>
    /// Views stats
    ///</summary>
    public class StatsViews
    {
        [JsonProperty("age")]
        public StatsSexAge[] Age { get; set; }
        [JsonProperty("cities")]
        public StatsCity[] Cities { get; set; }
        [JsonProperty("countries")]
        public StatsCountry[] Countries { get; set; }

        ///<summary>
        /// Number of views from mobile devices
        ///</summary>
        [JsonProperty("mobile_views")]
        public int MobileViews { get; set; }
        [JsonProperty("sex")]
        public StatsSexAge[] Sex { get; set; }
        [JsonProperty("sex_age")]
        public StatsSexAge[] SexAge { get; set; }

        ///<summary>
        /// Views number
        ///</summary>
        [JsonProperty("views")]
        public int Views { get; set; }

        ///<summary>
        /// Visitors number
        ///</summary>
        [JsonProperty("visitors")]
        public int Visitors { get; set; }
    }
}