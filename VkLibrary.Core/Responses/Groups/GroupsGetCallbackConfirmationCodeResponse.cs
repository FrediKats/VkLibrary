using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
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