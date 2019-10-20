using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
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
    }
}