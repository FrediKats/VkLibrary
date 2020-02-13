using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsRules
    {
        [JsonProperty("paragraphs")]
        public AdsParagraphs[] Paragraphs { get; set; }

        ///<summary>
        /// Comment
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}