using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
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