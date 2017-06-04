using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    public class Paragraphs
    {
        /// <summary>
        /// Rules paragraph
        /// </summary>
        [JsonProperty("paragraph")]
        public string Paragraph { get; set; }
    }
}