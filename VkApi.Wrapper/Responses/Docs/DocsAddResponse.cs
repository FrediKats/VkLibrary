using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class DocsAddResponse
    {
        ///<summary>
        /// Doc ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}