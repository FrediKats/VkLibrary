using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Database
{
    public class School
    {
        /// <summary>
        /// School ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// School title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}