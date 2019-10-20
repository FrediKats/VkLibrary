using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Scope description
    ///</summary>
    public class AppsScope
    {
        ///<summary>
        /// Scope name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// Scope title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}