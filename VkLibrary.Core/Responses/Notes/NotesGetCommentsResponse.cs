using Newtonsoft.Json;
using VkApi.Wrapper.Types.Notes;

namespace VkApi.Wrapper.Responses.Notes
{
    public class NotesGetCommentsResponse
    {
        ///<summary>
        /// Total number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public NotesNoteComment[] Items { get; set; }
    }
}