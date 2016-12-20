using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Places
{
    public class AddResponse
    {
        /// <summary>
        /// Place ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

    }
}
