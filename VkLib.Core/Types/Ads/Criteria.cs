using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class Criteria
    {
        /// <summary>
        /// Districts IDs
        /// </summary>
        [JsonProperty("districts")]
        public string Districts_ { get; set; }

        /// <summary>
        /// School graduation year from
        /// </summary>
        [JsonProperty("school_from")]
        public int? SchoolFrom { get; set; }

        /// <summary>
        /// Age from
        /// </summary>
        [JsonProperty("age_from")]
        public int? AgeFrom { get; set; }

        /// <summary>
        /// School graduation year to
        /// </summary>
        [JsonProperty("school_to")]
        public int? SchoolTo { get; set; }

        /// <summary>
        /// Days to birthday
        /// </summary>
        [JsonProperty("birthday")]
        public int? Birthday_ { get; set; }

        /// <summary>
        /// Interests
        /// </summary>
        [JsonProperty("interests")]
        public string Interests_ { get; set; }

        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("country")]
        public int? Country_ { get; set; }

        /// <summary>
        /// Travellers only
        /// </summary>
        [JsonProperty("travellers")]
        public string Travellers_ { get; set; }

        /// <summary>
        /// Devices
        /// </summary>
        [JsonProperty("user_devices")]
        public string UserDevices { get; set; }

        /// <summary>
        /// Positions IDs
        /// </summary>
        [JsonProperty("positions")]
        public string Positions_ { get; set; }

        /// <summary>
        /// Interests categories IDs
        /// </summary>
        [JsonProperty("interest_categories")]
        public string InterestCategories { get; set; }

        /// <summary>
        /// Apps IDs to except
        /// </summary>
        [JsonProperty("apps_not")]
        public string AppsNot { get; set; }

        /// <summary>
        /// Schools IDs
        /// </summary>
        [JsonProperty("schools")]
        public string Schools_ { get; set; }

        /// <summary>
        /// Operating systems
        /// </summary>
        [JsonProperty("user_os")]
        public string UserOs { get; set; }

        /// <summary>
        /// Religions IDs
        /// </summary>
        [JsonProperty("religions")]
        public string Religions_ { get; set; }

        /// <summary>
        /// Retargeting groups IDs to except
        /// </summary>
        [JsonProperty("retargeting_groups_not")]
        public string RetargetingGroupsNot { get; set; }

        /// <summary>
        /// Communities IDs
        /// </summary>
        [JsonProperty("groups")]
        public string Groups_ { get; set; }

        /// <summary>
        /// Retargeting groups IDs
        /// </summary>
        [JsonProperty("retargeting_groups")]
        public string RetargetingGroups { get; set; }

        /// <summary>
        /// University graduation year to
        /// </summary>
        [JsonProperty("uni_to")]
        public int? UniTo { get; set; }

        /// <summary>
        /// Cities IDs
        /// </summary>
        [JsonProperty("cities")]
        public string Cities_ { get; set; }

        /// <summary>
        /// University graduation year from
        /// </summary>
        [JsonProperty("uni_from")]
        public int? UniFrom { get; set; }

        /// <summary>
        /// Browsers
        /// </summary>
        [JsonProperty("user_browsers")]
        public string UserBrowsers { get; set; }

        /// <summary>
        /// Sex
        /// </summary>
        [JsonProperty("sex")]
        public int? Sex_ { get; set; }

        /// <summary>
        /// Relationship statuses
        /// </summary>
        [JsonProperty("statuses")]
        public string Statuses_ { get; set; }

        /// <summary>
        /// Cities IDs to except
        /// </summary>
        [JsonProperty("cities_not")]
        public string CitiesNot { get; set; }

        /// <summary>
        /// Information whether the user has proceeded VK payments before
        /// </summary>
        [JsonProperty("paying")]
        public int? Paying_ { get; set; }

        /// <summary>
        /// Stations IDs
        /// </summary>
        [JsonProperty("stations")]
        public string Stations_ { get; set; }

        /// <summary>
        /// Age to
        /// </summary>
        [JsonProperty("age_to")]
        public int? AgeTo { get; set; }

        /// <summary>
        /// Apps IDs
        /// </summary>
        [JsonProperty("apps")]
        public string Apps_ { get; set; }

        /// <summary>
        /// Streets IDs
        /// </summary>
        [JsonProperty("streets")]
        public string Streets_ { get; set; }

    }
}
