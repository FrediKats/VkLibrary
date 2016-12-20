using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Oauth 
{
    public class Error
    {
        /// <summary>
        /// Error description
        /// </summary>
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// URI for validation
        /// </summary>
        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Error type
        /// </summary>
        [JsonProperty("error")]
        public string Error_ { get; set; }

    }
}
