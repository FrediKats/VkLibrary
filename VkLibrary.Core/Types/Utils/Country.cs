using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Utils
{
    public class Country
    {
        [JsonProperty("country_id")]
        public int? CountryId { get; set; }

        [JsonProperty("views")]
        public int? Views { get; set; }
    }
}
