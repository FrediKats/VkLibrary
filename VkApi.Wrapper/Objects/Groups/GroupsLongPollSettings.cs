using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GroupsLongPollSettings
    {
        ///<summary>
        /// API version used for the events
        ///</summary>
        [JsonProperty("api_version")]
        public String ApiVersion { get; set; }
        [JsonProperty("events")]
        public GroupsLongPollEvents Events { get; set; }

        ///<summary>
        /// Shows whether Long Poll is enabled
        ///</summary>
        [JsonProperty("is_enabled")]
        public Boolean IsEnabled { get; set; }
    }
}