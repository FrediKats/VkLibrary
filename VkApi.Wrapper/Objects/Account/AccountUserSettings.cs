using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AccountUserSettings
    {
        ///<summary>
        /// URL of square photo of the user with 200 pixels in width
        ///</summary>
        [JsonProperty("photo_200")]
        public String Photo200 { get; set; }
    }
}