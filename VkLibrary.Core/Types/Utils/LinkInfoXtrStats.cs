using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Utils
{
    public class LinkInfoXtrStats : LinkInfoFull
    {
        [JsonProperty("sex_age")]
        public List<SexAge> SexAge { get; set; }

        [JsonProperty("countries")]
        public List<Country> Countries { get; set; }

        [JsonProperty("cities")]
        public List<City> Cities { get; set; }
    }
}
