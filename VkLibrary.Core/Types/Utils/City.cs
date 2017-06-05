using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Utils
{
    public class City
    {
        [JsonProperty("city_id")]
        public int? CountryId { get; set; }

        [JsonProperty("views")]
        public int? Views { get; set; }
    }
}
