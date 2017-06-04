using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Friends
{
    public class AddListResponse
    {
        /// <summary>
        /// List ID
        /// </summary>
        [JsonProperty("list_id")]
        public int? ListId { get; set; }
    }
}