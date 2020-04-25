using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class StoriesGetViewersExtendedV5115Response
    {
        ///<summary>
        /// Viewers count
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public StoriesViewersItem[] Items { get; set; }
        [JsonProperty("hidden_reason")]
        public String HiddenReason { get; set; }
    }
}