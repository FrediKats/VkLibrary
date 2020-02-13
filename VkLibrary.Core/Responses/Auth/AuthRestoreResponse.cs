using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Auth
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