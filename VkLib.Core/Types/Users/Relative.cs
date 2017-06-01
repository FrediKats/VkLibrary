using Newtonsoft.Json;

namespace VkLib.Types.Users
{
    public class Relative
    {
        /// <summary>
        ///     Relative type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Relative ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}