using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Newsfeed
{
    public class ItemNote
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("notes")]
        public ItemNoteNotes Notes { get; set; }
    }
}