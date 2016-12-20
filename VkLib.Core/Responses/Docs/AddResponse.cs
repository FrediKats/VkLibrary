using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Docs
{
    public class AddResponse
    {
        /// <summary>
        /// Doc ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

    }
}
