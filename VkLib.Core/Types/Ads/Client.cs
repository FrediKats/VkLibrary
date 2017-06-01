using Newtonsoft.Json;

namespace VkLib.Types.Ads
{
    public class Client
    {
        /// <summary>
        ///     Client's total limit, rubles
        /// </summary>
        [JsonProperty("all_limit")]
        public string AllLimit { get; set; }

        /// <summary>
        ///     Client ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     Client's day limit, rubles
        /// </summary>
        [JsonProperty("day_limit")]
        public string DayLimit { get; set; }

        /// <summary>
        ///     Client name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}