using Newtonsoft.Json;

namespace VkLib.Responses.Groups
{
    public class EditPlaceResponse
    {
        /// <summary>
        ///     None
        /// </summary>
        [JsonProperty("success")]
        public int Success { get; set; }

        /// <summary>
        ///     Place address
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
    }
}