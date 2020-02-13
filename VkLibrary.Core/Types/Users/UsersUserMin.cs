using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Users
{
    public class UsersUserMin
    {
        ///<summary>
        /// Returns if a profile is deleted or blocked
        ///</summary>
        [JsonProperty("deactivated")]
        public String Deactivated { get; set; }

        ///<summary>
        /// User first name
        ///</summary>
        [JsonProperty("first_name")]
        public String FirstName { get; set; }

        ///<summary>
        /// Returns if a profile is hidden.
        ///</summary>
        [JsonProperty("hidden")]
        public int Hidden { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// User last name
        ///</summary>
        [JsonProperty("last_name")]
        public String LastName { get; set; }
        [JsonProperty("can_access_closed")]
        public Boolean CanAccessClosed { get; set; }
        [JsonProperty("is_closed")]
        public Boolean IsClosed { get; set; }
    }
}