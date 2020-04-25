using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class OauthError
    {
        ///<summary>
        /// Error type
        ///</summary>
        [JsonProperty("error")]
        public String Error { get; set; }

        ///<summary>
        /// Error description
        ///</summary>
        [JsonProperty("error_description")]
        public String ErrorDescription { get; set; }

        ///<summary>
        /// URI for validation
        ///</summary>
        [JsonProperty("redirect_uri")]
        public String RedirectUri { get; set; }
    }
}