using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class AdsLinkStatus
    {
        ///<summary>
        /// Reject reason
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// URL
        ///</summary>
        [JsonProperty("redirect_url")]
        public String RedirectUrl { get; set; }

        ///<summary>
        /// Link status
        ///</summary>
        [JsonProperty("status")]
        public String Status { get; set; }
    }
}