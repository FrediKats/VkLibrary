using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Groups
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