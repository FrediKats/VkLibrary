using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedItemNoteNotes
    {
        ///<summary>
        /// Notes number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public NewsfeedNewsfeedNote[] Items { get; set; }
    }
}