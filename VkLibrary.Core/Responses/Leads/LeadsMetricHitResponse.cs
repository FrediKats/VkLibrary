using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class LeadsMetricHitResponse
    {
        ///<summary>
        /// Information whether request has been processed successfully
        ///</summary>
        [JsonProperty("result")]
        public Boolean Result { get; set; }

        ///<summary>
        /// Redirect link
        ///</summary>
        [JsonProperty("redirect_link")]
        public String RedirectLink { get; set; }
    }
}