using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class UsersUserSettingsXtr
    {
        [JsonProperty("connections")]
        public UsersUserConnections Connections { get; set; }

        ///<summary>
        /// User's date of birth
        ///</summary>
        [JsonProperty("bdate")]
        public String Bdate { get; set; }

        ///<summary>
        /// Information whether user's birthdate are hidden
        ///</summary>
        [JsonProperty("bdate_visibility")]
        public int BdateVisibility { get; set; }
        [JsonProperty("city")]
        public BaseCity City { get; set; }
        [JsonProperty("country")]
        public BaseCountry Country { get; set; }

        ///<summary>
        /// User first name
        ///</summary>
        [JsonProperty("first_name")]
        public String FirstName { get; set; }

        ///<summary>
        /// User's hometown
        ///</summary>
        [JsonProperty("home_town")]
        public String HomeTown { get; set; }

        ///<summary>
        /// User last name
        ///</summary>
        [JsonProperty("last_name")]
        public String LastName { get; set; }

        ///<summary>
        /// User maiden name
        ///</summary>
        [JsonProperty("maiden_name")]
        public String MaidenName { get; set; }
        [JsonProperty("name_request")]
        public AccountNameRequest NameRequest { get; set; }
        [JsonProperty("personal")]
        public UsersPersonal Personal { get; set; }

        ///<summary>
        /// User phone number with some hidden digits
        ///</summary>
        [JsonProperty("phone")]
        public String Phone { get; set; }

        ///<summary>
        /// User relationship status
        ///</summary>
        [JsonProperty("relation")]
        public UsersUserRelation Relation { get; set; }
        [JsonProperty("relation_partner")]
        public UsersUserMin RelationPartner { get; set; }

        ///<summary>
        /// Information whether relation status is pending
        ///</summary>
        [JsonProperty("relation_pending")]
        public int RelationPending { get; set; }
        [JsonProperty("relation_requests")]
        public UsersUserMin[] RelationRequests { get; set; }

        ///<summary>
        /// Domain name of the user's page
        ///</summary>
        [JsonProperty("screen_name")]
        public String ScreenName { get; set; }

        ///<summary>
        /// User sex
        ///</summary>
        [JsonProperty("sex")]
        public BaseSex Sex { get; set; }

        ///<summary>
        /// User status
        ///</summary>
        [JsonProperty("status")]
        public String Status { get; set; }
        [JsonProperty("status_audio")]
        public AudioAudio StatusAudio { get; set; }
        [JsonProperty("interests")]
        public AccountUserSettingsInterests Interests { get; set; }
        [JsonProperty("languages")]
        public String[] Languages { get; set; }
    }
}