using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Base
{
    public class BaseMessageError
    {
        ///<summary>
        /// Error code
        ///</summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        ///<summary>
        /// Error message
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }
    }
}