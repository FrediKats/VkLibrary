using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Account 
{
    public class Offer
    {
        /// <summary>
        /// Offer ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// Instruction how to process the offer
        /// </summary>
        [JsonProperty("instruction")]
        public string Instruction_ { get; set; }

        /// <summary>
        /// Offer price
        /// </summary>
        [JsonProperty("price")]
        public int? Price_ { get; set; }

        /// <summary>
        /// Instruction how to process the offer (HTML format)
        /// </summary>
        [JsonProperty("instruction_html")]
        public string InstructionHtml { get; set; }

        /// <summary>
        /// Offer tag
        /// </summary>
        [JsonProperty("tag")]
        public string Tag_ { get; set; }

        /// <summary>
        /// Offer short description
        /// </summary>
        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Offer description
        /// </summary>
        [JsonProperty("description")]
        public string Description_ { get; set; }

        /// <summary>
        /// Offer title
        /// </summary>
        [JsonProperty("title")]
        public string Title_ { get; set; }

        /// <summary>
        /// URL of the preview image
        /// </summary>
        [JsonProperty("img")]
        public string Img_ { get; set; }

    }
}
