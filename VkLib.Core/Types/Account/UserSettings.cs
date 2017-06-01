using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Base;
using VkLib.Types.Users;

namespace VkLib.Types.Account
{
    public class UserSettings
    {
        /// <summary>
        ///     User sex
        /// </summary>
        [JsonProperty("sex")]
        public int? Sex { get; set; }

        /// <summary>
        ///     User status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        ///     User relationship status
        /// </summary>
        [JsonProperty("relation")]
        public int? Relation { get; set; }

        /// <summary>
        ///     Domain name of the user's page
        /// </summary>
        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("name_request")]
        public NameRequest NameRequest { get; set; }

        /// <summary>
        ///     User's hometown
        /// </summary>
        [JsonProperty("home_town")]
        public string HomeTown { get; set; }

        /// <summary>
        ///     User maiden name
        /// </summary>
        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("relation_partner")]
        public UserMin RelationPartner { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("city")]
        public Object City { get; set; }

        /// <summary>
        ///     User last name
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        ///     User's date of birth
        /// </summary>
        [JsonProperty("bdate")]
        public string Bdate { get; set; }

        /// <summary>
        ///     Information whether user's birthdate are hidden
        /// </summary>
        [JsonProperty("bdate_visibility")]
        public int? BdateVisibility { get; set; }

        /// <summary>
        ///     User phone number with some hidden digits
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("relation_requests")]
        public IEnumerable<UserMin> RelationRequests { get; set; }

        /// <summary>
        ///     Information whether relation status is pending
        /// </summary>
        [JsonProperty("relation_pending")]
        public int? RelationPending { get; set; }

        /// <summary>
        ///     User first name
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("country")]
        public Country Country { get; set; }
    }
}