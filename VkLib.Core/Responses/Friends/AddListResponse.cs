using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Friends
{
    public class AddListResponse
    {
        /// <summary>
        /// List ID
        /// </summary>
        [JsonProperty("list_id")]
        public int? ListId { get; set; }

    }
}
