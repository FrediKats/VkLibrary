using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class AccountSaveProfileInfoResponse
    {
        ///<summary>
        /// 1 if changes has been processed
        ///</summary>
        [JsonProperty("changed")]
        public int Changed { get; set; }
        [JsonProperty("name_request")]
        public AccountNameRequest NameRequest { get; set; }
    }
}