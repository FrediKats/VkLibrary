using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class GroupsGetSettingsResponse
    {
        ///<summary>
        /// Community access settings
        ///</summary>
        [JsonProperty("access")]
        public int Access { get; set; }

        ///<summary>
        /// Community's page domain
        ///</summary>
        [JsonProperty("address")]
        public String Address { get; set; }

        ///<summary>
        /// Audio settings
        ///</summary>
        [JsonProperty("audio")]
        public int Audio { get; set; }

        ///<summary>
        /// Articles settings
        ///</summary>
        [JsonProperty("articles")]
        public int Articles { get; set; }

        ///<summary>
        /// City id of group
        ///</summary>
        [JsonProperty("city_id")]
        public int CityId { get; set; }
        [JsonProperty("contacts")]
        public int Contacts { get; set; }
        [JsonProperty("links")]
        public int Links { get; set; }
        [JsonProperty("sections_list")]
        public Object SectionsList { get; set; }
        [JsonProperty("main_section")]
        public GroupsGroupFullMainSection MainSection { get; set; }
        [JsonProperty("secondary_section")]
        public int SecondarySection { get; set; }
        [JsonProperty("age_limits")]
        public int AgeLimits { get; set; }

        ///<summary>
        /// Country id of group
        ///</summary>
        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        ///<summary>
        /// Community description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// Docs settings
        ///</summary>
        [JsonProperty("docs")]
        public int Docs { get; set; }
        [JsonProperty("events")]
        public int Events { get; set; }

        ///<summary>
        /// Information whether the obscene filter is enabled
        ///</summary>
        [JsonProperty("obscene_filter")]
        public int ObsceneFilter { get; set; }

        ///<summary>
        /// Information whether the stopwords filter is enabled
        ///</summary>
        [JsonProperty("obscene_stopwords")]
        public int ObsceneStopwords { get; set; }

        ///<summary>
        /// The list of stop words
        ///</summary>
        [JsonProperty("obscene_words")]
        public String[] ObsceneWords { get; set; }
        [JsonProperty("event_group_id")]
        public int EventGroupId { get; set; }

        ///<summary>
        /// Photos settings
        ///</summary>
        [JsonProperty("photos")]
        public int Photos { get; set; }

        ///<summary>
        /// Information about the group category
        ///</summary>
        [JsonProperty("public_category")]
        public int PublicCategory { get; set; }
        [JsonProperty("public_category_list")]
        public GroupsGroupPublicCategoryList[] PublicCategoryList { get; set; }
        [JsonProperty("public_date")]
        public String PublicDate { get; set; }
        [JsonProperty("public_date_label")]
        public String PublicDateLabel { get; set; }

        ///<summary>
        /// Information about the group subcategory
        ///</summary>
        [JsonProperty("public_subcategory")]
        public int PublicSubcategory { get; set; }

        ///<summary>
        /// URL of the RSS feed
        ///</summary>
        [JsonProperty("rss")]
        public String Rss { get; set; }

        ///<summary>
        /// Start date
        ///</summary>
        [JsonProperty("start_date")]
        public int StartDate { get; set; }

        ///<summary>
        /// Finish date in Unixtime format
        ///</summary>
        [JsonProperty("finish_date")]
        public int FinishDate { get; set; }

        ///<summary>
        /// Community subject ID
        ///</summary>
        [JsonProperty("subject")]
        public int Subject { get; set; }
        [JsonProperty("subject_list")]
        public GroupsSubjectItem[] SubjectList { get; set; }
        [JsonProperty("suggested_privacy")]
        public int SuggestedPrivacy { get; set; }

        ///<summary>
        /// Community title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Topics settings
        ///</summary>
        [JsonProperty("topics")]
        public int Topics { get; set; }
        [JsonProperty("twitter")]
        public GroupsSettingsTwitter Twitter { get; set; }

        ///<summary>
        /// Video settings
        ///</summary>
        [JsonProperty("video")]
        public int Video { get; set; }

        ///<summary>
        /// Wall settings
        ///</summary>
        [JsonProperty("wall")]
        public int Wall { get; set; }

        ///<summary>
        /// Community website
        ///</summary>
        [JsonProperty("website")]
        public String Website { get; set; }

        ///<summary>
        /// Community phone
        ///</summary>
        [JsonProperty("phone")]
        public String Phone { get; set; }

        ///<summary>
        /// Community email
        ///</summary>
        [JsonProperty("email")]
        public String Email { get; set; }

        ///<summary>
        /// Wiki settings
        ///</summary>
        [JsonProperty("wiki")]
        public int Wiki { get; set; }
    }
}