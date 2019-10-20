using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class GroupsCallbackSettings
    {
        ///<summary>
        /// API version used for the events
        ///</summary>
        [JsonProperty("api_version")]
        public String ApiVersion { get; set; }
        [JsonProperty("events")]
        public GroupsLongPollEvents Events { get; set; }
    }
}