using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedItemNote
    {
        [JsonProperty("notes")]
        public NewsfeedItemNoteNotes Notes { get; set; }
    }
}