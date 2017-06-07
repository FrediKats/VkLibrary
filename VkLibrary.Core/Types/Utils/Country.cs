using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Utils
{
    /// <summary>
    /// API Country object.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Country id in country list.
        /// </summary>
        [JsonProperty("country_id")]
        public int? CountryId { get; set; }

        /// <summary>
        /// Views  count.
        /// </summary>
        [JsonProperty("views")]
        public int? Views { get; set; }
    }
}
