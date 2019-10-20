using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UsersLastSeen
    {
        ///<summary>
        /// Type of the platform that used for the last authorization
        ///</summary>
        [JsonProperty("platform")]
        public int Platform { get; set; }

        ///<summary>
        /// Last visit date (in Unix time)
        ///</summary>
        [JsonProperty("time")]
        public int Time { get; set; }
    }
}