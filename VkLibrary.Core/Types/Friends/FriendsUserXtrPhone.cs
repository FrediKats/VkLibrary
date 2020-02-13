using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Friends
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