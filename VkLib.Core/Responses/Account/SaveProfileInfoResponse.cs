using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Account
{
    public class SaveProfileInfoResponse
    {
        /// <summary>
        /// 1 if changes has been processed
        /// </summary>
        [JsonProperty("changed")]
        public int Changed { get; set; }

        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("name_request")]
        public VkLib.Types.Account.NameRequest NameRequest { get; set; }

    }
}
