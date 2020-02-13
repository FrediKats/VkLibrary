using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Leads
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