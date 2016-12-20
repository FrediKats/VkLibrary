using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Account 
{
    public class UserSettings
    {
        /// <summary>
        /// User's date of birth
        /// </summary>
        [JsonProperty("bdate")]
        public string Bdate { get; set; }

        /// <summary>
        /// User phone number with some hidden digits
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("relation_requests")]
        public IEnumerable<VkLib.Types.Users.UserMin> RelationRequests_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("city")]
        public VkLib.Types.Base.Object City { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("country")]
        public VkLib.Types.Base.Country Country { get; set; }

        /// <summary>
        /// User status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Domain name of the user's page
        /// </summary>
        [JsonProperty("screen_name")]
        public string ScreenName_ { get; set; }

        /// <summary>
        /// User first name
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("relation_partner")]
        public VkLib.Types.Users.UserMin RelationPartner_ { get; set; }

        /// <summary>
        /// User last name
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName_ { get; set; }

        /// <summary>
        /// User sex
        /// </summary>
        [JsonProperty("sex")]
        public int? Sex { get; set; }

        /// <summary>
        /// User maiden name
        /// </summary>
        [JsonProperty("maiden_name")]
        public string MaidenName_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("name_request")]
        public VkLib.Types.Account.NameRequest NameRequest_ { get; set; }

        /// <summary>
        /// User's hometown
        /// </summary>
        [JsonProperty("home_town")]
        public string HomeTown_ { get; set; }

        /// <summary>
        /// User relationship status
        /// </summary>
        [JsonProperty("relation")]
        public int? Relation { get; set; }

        /// <summary>
        /// Information whether relation status is pending
        /// </summary>
        [JsonProperty("relation_pending")]
        public int? RelationPending_ { get; set; }

        /// <summary>
        /// Information whether user's birthdate are hidden
        /// </summary>
        [JsonProperty("bdate_visibility")]
        public int? BdateVisibility_ { get; set; }

    }
}
