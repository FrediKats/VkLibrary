using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Newsfeed
{
    /// <summary>
    /// API ItemNote object.
    /// </summary>
    public class ItemNote
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("notes")]
        public ItemNoteNotes Notes { get; set; }
    }
}