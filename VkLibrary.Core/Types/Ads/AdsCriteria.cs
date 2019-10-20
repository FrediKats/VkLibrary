using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class AdsCriteria
    {
        ///<summary>
        /// Age from
        ///</summary>
        [JsonProperty("age_from")]
        public int AgeFrom { get; set; }

        ///<summary>
        /// Age to
        ///</summary>
        [JsonProperty("age_to")]
        public int AgeTo { get; set; }

        ///<summary>
        /// Apps IDs
        ///</summary>
        [JsonProperty("apps")]
        public String Apps { get; set; }

        ///<summary>
        /// Apps IDs to except
        ///</summary>
        [JsonProperty("apps_not")]
        public String AppsNot { get; set; }

        ///<summary>
        /// Days to birthday
        ///</summary>
        [JsonProperty("birthday")]
        public int Birthday { get; set; }

        ///<summary>
        /// Cities IDs
        ///</summary>
        [JsonProperty("cities")]
        public String Cities { get; set; }

        ///<summary>
        /// Cities IDs to except
        ///</summary>
        [JsonProperty("cities_not")]
        public String CitiesNot { get; set; }

        ///<summary>
        /// Country ID
        ///</summary>
        [JsonProperty("country")]
        public int Country { get; set; }

        ///<summary>
        /// Districts IDs
        ///</summary>
        [JsonProperty("districts")]
        public String Districts { get; set; }

        ///<summary>
        /// Communities IDs
        ///</summary>
        [JsonProperty("groups")]
        public String Groups { get; set; }

        ///<summary>
        /// Interests categories IDs
        ///</summary>
        [JsonProperty("interest_categories")]
        public String InterestCategories { get; set; }

        ///<summary>
        /// Interests
        ///</summary>
        [JsonProperty("interests")]
        public String Interests { get; set; }

        ///<summary>
        /// Information whether the user has proceeded VK payments before
        ///</summary>
        [JsonProperty("paying")]
        public int Paying { get; set; }

        ///<summary>
        /// Positions IDs
        ///</summary>
        [JsonProperty("positions")]
        public String Positions { get; set; }

        ///<summary>
        /// Religions IDs
        ///</summary>
        [JsonProperty("religions")]
        public String Religions { get; set; }

        ///<summary>
        /// Retargeting groups IDs
        ///</summary>
        [JsonProperty("retargeting_groups")]
        public String RetargetingGroups { get; set; }

        ///<summary>
        /// Retargeting groups IDs to except
        ///</summary>
        [JsonProperty("retargeting_groups_not")]
        public String RetargetingGroupsNot { get; set; }

        ///<summary>
        /// School graduation year from
        ///</summary>
        [JsonProperty("school_from")]
        public int SchoolFrom { get; set; }

        ///<summary>
        /// School graduation year to
        ///</summary>
        [JsonProperty("school_to")]
        public int SchoolTo { get; set; }

        ///<summary>
        /// Schools IDs
        ///</summary>
        [JsonProperty("schools")]
        public String Schools { get; set; }
        [JsonProperty("sex")]
        public AdsCriteriaSex Sex { get; set; }

        ///<summary>
        /// Stations IDs
        ///</summary>
        [JsonProperty("stations")]
        public String Stations { get; set; }

        ///<summary>
        /// Relationship statuses
        ///</summary>
        [JsonProperty("statuses")]
        public String Statuses { get; set; }

        ///<summary>
        /// Streets IDs
        ///</summary>
        [JsonProperty("streets")]
        public String Streets { get; set; }

        ///<summary>
        /// Travellers only
        ///</summary>
        [JsonProperty("travellers")]
        public BasePropertyExists Travellers { get; set; }

        ///<summary>
        /// University graduation year from
        ///</summary>
        [JsonProperty("uni_from")]
        public int UniFrom { get; set; }

        ///<summary>
        /// University graduation year to
        ///</summary>
        [JsonProperty("uni_to")]
        public int UniTo { get; set; }

        ///<summary>
        /// Browsers
        ///</summary>
        [JsonProperty("user_browsers")]
        public String UserBrowsers { get; set; }

        ///<summary>
        /// Devices
        ///</summary>
        [JsonProperty("user_devices")]
        public String UserDevices { get; set; }

        ///<summary>
        /// Operating systems
        ///</summary>
        [JsonProperty("user_os")]
        public String UserOs { get; set; }
    }
}