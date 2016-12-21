using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Auth
{
    public class RestoreResponse
    {
        /// <summary>
        /// 1 if success
        /// </summary>
        [JsonProperty("success")]
        public int? Success { get; set; }

        /// <summary>
        /// Parameter needed to grant access by code
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; set; }

    }
}