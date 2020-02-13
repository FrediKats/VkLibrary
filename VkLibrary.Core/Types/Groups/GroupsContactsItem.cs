using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsContactsItem
    {
        ///<summary>
        /// Contact description
        ///</summary>
        [JsonProperty("desc")]
        public String Desc { get; set; }

        ///<summary>
        /// Contact email
        ///</summary>
        [JsonProperty("email")]
        public String Email { get; set; }

        ///<summary>
        /// Contact phone
        ///</summary>
        [JsonProperty("phone")]
        public String Phone { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}