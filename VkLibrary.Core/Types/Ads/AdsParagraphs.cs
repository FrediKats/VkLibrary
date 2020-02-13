using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsParagraphs
    {
        ///<summary>
        /// Rules paragraph
        ///</summary>
        [JsonProperty("paragraph")]
        public String Paragraph { get; set; }
    }
}