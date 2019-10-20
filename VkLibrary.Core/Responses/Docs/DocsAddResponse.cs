using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
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