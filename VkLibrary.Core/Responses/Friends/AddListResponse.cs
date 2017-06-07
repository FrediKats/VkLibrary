using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Friends
{
    /// <summary>
    /// API AddListResponse.
    /// </summary>
    public class AddListResponse
    {
        /// <summary>
        /// List ID
        /// </summary>
        [JsonProperty("list_id")]
        public int? ListId { get; set; }
    }
}