using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class GroupsGroupSettings
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
        /// Community description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// Docs settings
        ///</summary>
        [JsonProperty("docs")]
        public int Docs { get; set; }

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
        public String ObsceneWords { get; set; }

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
        /// Community subject ID
        ///</summary>
        [JsonProperty("subject")]
        public int Subject { get; set; }
        [JsonProperty("subject_list")]
        public GroupsSubjectItem[] SubjectList { get; set; }

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
        /// Wiki settings
        ///</summary>
        [JsonProperty("wiki")]
        public int Wiki { get; set; }
    }
}