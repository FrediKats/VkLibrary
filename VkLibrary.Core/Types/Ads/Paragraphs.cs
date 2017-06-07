using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    /// <summary>
    /// API Paragraphs object.
    /// </summary>
    public class Paragraphs
    {
        /// <summary>
        /// Rules paragraph
        /// </summary>
        [JsonProperty("paragraph")]
        public string Paragraph { get; set; }
    }
}