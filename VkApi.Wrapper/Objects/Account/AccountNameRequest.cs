using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AccountNameRequest
    {
        ///<summary>
        /// First name in request
        ///</summary>
        [JsonProperty("first_name")]
        public String FirstName { get; set; }

        ///<summary>
        /// Request ID needed to cancel the request
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Last name in request
        ///</summary>
        [JsonProperty("last_name")]
        public String LastName { get; set; }
        [JsonProperty("status")]
        public AccountNameRequestStatus Status { get; set; }

        ///<summary>
        /// Text to display to user
        ///</summary>
        [JsonProperty("lang")]
        public String Lang { get; set; }

        ///<summary>
        /// href for link in lang field
        ///</summary>
        [JsonProperty("link_href")]
        public String LinkHref { get; set; }

        ///<summary>
        /// label to display for link in lang field
        ///</summary>
        [JsonProperty("link_label")]
        public String LinkLabel { get; set; }
    }
}