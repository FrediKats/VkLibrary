using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed
{
    public class ItemNote
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("notes")]
        public ItemNoteNotes Notes { get; set; }
    }
}