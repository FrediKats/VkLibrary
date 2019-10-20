using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class FriendsUserXtrPhone
    {
        ///<summary>
        /// User phone
        ///</summary>
        [JsonProperty("phone")]
        public String Phone { get; set; }
    }
}