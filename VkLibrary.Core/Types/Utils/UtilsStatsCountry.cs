using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Utils
{
    public class UtilsStatsCountry
    {
        ///<summary>
        /// Country ID
        ///</summary>
        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        ///<summary>
        /// Views number
        ///</summary>
        [JsonProperty("views")]
        public int Views { get; set; }
    }
}