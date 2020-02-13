using Newtonsoft.Json;
using VkApi.Wrapper.Types.Notes;

namespace VkApi.Wrapper.Responses.Notes
{
    public class NotesGetResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public NotesNote[] Items { get; set; }
    }
}