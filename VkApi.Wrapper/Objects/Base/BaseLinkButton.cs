using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class BaseLinkButton
    {
        ///<summary>
        /// Button action
        ///</summary>
        [JsonProperty("action")]
        public BaseLinkButtonAction Action { get; set; }

        ///<summary>
        /// Button title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Target block id
        ///</summary>
        [JsonProperty("block_id")]
        public String BlockId { get; set; }

        ///<summary>
        /// Target section id
        ///</summary>
        [JsonProperty("section_id")]
        public String SectionId { get; set; }

        ///<summary>
        /// Owner id
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// Button icon name, e.g. 'phone' or 'gift'
        ///</summary>
        [JsonProperty("icon")]
        public String Icon { get; set; }
        [JsonProperty("style")]
        public BaseLinkButtonStyle Style { get; set; }
    }
}