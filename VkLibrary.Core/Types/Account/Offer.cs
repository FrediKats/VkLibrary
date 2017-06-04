using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Account
{
    public class Offer
    {
        /// <summary>
        /// Instruction how to process the offer
        /// </summary>
        [JsonProperty("instruction")]
        public string Instruction { get; set; }

        /// <summary>
        /// Offer short description
        /// </summary>
        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Instruction how to process the offer (HTML format)
        /// </summary>
        [JsonProperty("instruction_html")]
        public string InstructionHtml { get; set; }

        /// <summary>
        /// Offer ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Offer tag
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Offer description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Offer price
        /// </summary>
        [JsonProperty("price")]
        public int? Price { get; set; }

        /// <summary>
        /// Offer title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// URL of the preview image
        /// </summary>
        [JsonProperty("img")]
        public string Img { get; set; }
    }
}