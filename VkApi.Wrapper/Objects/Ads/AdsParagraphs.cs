using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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