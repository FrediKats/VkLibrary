using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Places
{
    public class CheckinResponse
    {
        /// <summary>
        /// Checkin ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

    }
}
