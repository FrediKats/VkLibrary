using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Utils
{
    /// <summary>
    /// API City object.
    /// </summary>
    public class City
    {
        /// <summary>
        /// City id in city list.
        /// </summary>
        [JsonProperty("city_id")]
        public int? CityId { get; set; }

        /// <summary>
        /// Views count.
        /// </summary>
        [JsonProperty("views")]
        public int? Views { get; set; }
    }
}
