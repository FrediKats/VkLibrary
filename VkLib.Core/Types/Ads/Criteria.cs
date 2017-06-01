using Newtonsoft.Json;

namespace VkLib.Types.Ads
{
    public class Criteria
    {
        /// <summary>
        ///     Sex
        /// </summary>
        [JsonProperty("sex")]
        public int? Sex { get; set; }

        /// <summary>
        ///     Streets IDs
        /// </summary>
        [JsonProperty("streets")]
        public string Streets { get; set; }

        /// <summary>
        ///     Cities IDs to except
        /// </summary>
        [JsonProperty("cities_not")]
        public string CitiesNot { get; set; }

        /// <summary>
        ///     Operating systems
        /// </summary>
        [JsonProperty("user_os")]
        public string UserOs { get; set; }

        /// <summary>
        ///     Retargeting groups IDs to except
        /// </summary>
        [JsonProperty("retargeting_groups_not")]
        public string RetargetingGroupsNot { get; set; }

        /// <summary>
        ///     Age to
        /// </summary>
        [JsonProperty("age_to")]
        public int? AgeTo { get; set; }

        /// <summary>
        ///     Relationship statuses
        /// </summary>
        [JsonProperty("statuses")]
        public string Statuses { get; set; }

        /// <summary>
        ///     Browsers
        /// </summary>
        [JsonProperty("user_browsers")]
        public string UserBrowsers { get; set; }

        /// <summary>
        ///     Travellers only
        /// </summary>
        [JsonProperty("travellers")]
        public string Travellers { get; set; }

        /// <summary>
        ///     School graduation year from
        /// </summary>
        [JsonProperty("school_from")]
        public int? SchoolFrom { get; set; }

        /// <summary>
        ///     School graduation year to
        /// </summary>
        [JsonProperty("school_to")]
        public int? SchoolTo { get; set; }

        /// <summary>
        ///     Interests
        /// </summary>
        [JsonProperty("interests")]
        public string Interests { get; set; }

        /// <summary>
        ///     Schools IDs
        /// </summary>
        [JsonProperty("schools")]
        public string Schools { get; set; }

        /// <summary>
        ///     Stations IDs
        /// </summary>
        [JsonProperty("stations")]
        public string Stations { get; set; }

        /// <summary>
        ///     Days to birthday
        /// </summary>
        [JsonProperty("birthday")]
        public int? Birthday { get; set; }

        /// <summary>
        ///     Communities IDs
        /// </summary>
        [JsonProperty("groups")]
        public string Groups { get; set; }

        /// <summary>
        ///     Positions IDs
        /// </summary>
        [JsonProperty("positions")]
        public string Positions { get; set; }

        /// <summary>
        ///     Retargeting groups IDs
        /// </summary>
        [JsonProperty("retargeting_groups")]
        public string RetargetingGroups { get; set; }

        /// <summary>
        ///     Apps IDs to except
        /// </summary>
        [JsonProperty("apps_not")]
        public string AppsNot { get; set; }

        /// <summary>
        ///     University graduation year to
        /// </summary>
        [JsonProperty("uni_to")]
        public int? UniTo { get; set; }

        /// <summary>
        ///     Religions IDs
        /// </summary>
        [JsonProperty("religions")]
        public string Religions { get; set; }

        /// <summary>
        ///     Age from
        /// </summary>
        [JsonProperty("age_from")]
        public int? AgeFrom { get; set; }

        /// <summary>
        ///     University graduation year from
        /// </summary>
        [JsonProperty("uni_from")]
        public int? UniFrom { get; set; }

        /// <summary>
        ///     Devices
        /// </summary>
        [JsonProperty("user_devices")]
        public string UserDevices { get; set; }

        /// <summary>
        ///     Cities IDs
        /// </summary>
        [JsonProperty("cities")]
        public string Cities { get; set; }

        /// <summary>
        ///     Interests categories IDs
        /// </summary>
        [JsonProperty("interest_categories")]
        public string InterestCategories { get; set; }

        /// <summary>
        ///     Districts IDs
        /// </summary>
        [JsonProperty("districts")]
        public string Districts { get; set; }

        /// <summary>
        ///     Apps IDs
        /// </summary>
        [JsonProperty("apps")]
        public string Apps { get; set; }

        /// <summary>
        ///     Country ID
        /// </summary>
        [JsonProperty("country")]
        public int? Country { get; set; }

        /// <summary>
        ///     Information whether the user has proceeded VK payments before
        /// </summary>
        [JsonProperty("paying")]
        public int? Paying { get; set; }
    }
}