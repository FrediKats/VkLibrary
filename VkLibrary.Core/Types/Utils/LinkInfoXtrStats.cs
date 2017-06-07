using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Utils
{
    /// <summary>
    /// API LinkInfoXtrStats object.
    /// </summary>
    public class LinkInfoXtrStats : LinkInfoFull
    {
        /// <summary>
        /// Sex and age info.
        /// </summary>
        [JsonProperty("sex_age")]
        public List<SexAge> SexAge { get; set; }

        /// <summary>
        /// Countries list.
        /// </summary>
        [JsonProperty("countries")]
        public List<Country> Countries { get; set; }

        /// <summary>
        /// Cities list.
        /// </summary>
        [JsonProperty("cities")]
        public List<City> Cities { get; set; }
    }
}
