using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class AuthRestoreResponse
    {
        ///<summary>
        /// 1 if success
        ///</summary>
        [JsonProperty("success")]
        public int Success { get; set; }

        ///<summary>
        /// Parameter needed to grant access by code
        ///</summary>
        [JsonProperty("sid")]
        public String Sid { get; set; }
    }
}