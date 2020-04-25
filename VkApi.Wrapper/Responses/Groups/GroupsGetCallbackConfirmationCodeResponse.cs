using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class GroupsGetCallbackConfirmationCodeResponse
    {
        ///<summary>
        /// Confirmation code
        ///</summary>
        [JsonProperty("code")]
        public String Code { get; set; }
    }
}