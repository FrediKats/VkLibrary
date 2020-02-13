using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Users
{
    public class UsersRelative
    {
        ///<summary>
        /// Date of child birthday (format dd.mm.yyyy)
        ///</summary>
        [JsonProperty("birth_date")]
        public String BirthDate { get; set; }

        ///<summary>
        /// Relative ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Name of relative
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// Relative type
        ///</summary>
        [JsonProperty("type")]
        public String Type { get; set; }
    }
}