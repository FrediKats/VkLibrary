using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Places;

namespace VkLibrary.Core.Types.Groups
{
    public class GroupSettings
    {
        /// <summary>
        /// Community's page domain
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Wiki settings
        /// </summary>
        [JsonProperty("wiki")]
        public int? Wiki { get; set; }

        /// <summary>
        /// Community subject ID
        /// </summary>
        [JsonProperty("subject")]
        public int? Subject { get; set; }

        /// <summary>
        /// Community website
        /// </summary>
        [JsonProperty("website")]
        public string Website { get; set; }

        /// <summary>
        /// Information whether the stopwords filter is enabled
        /// </summary>
        [JsonProperty("obscene_stopwords")]
        public int? ObsceneStopwords { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("place")]
        public PlaceMin Place { get; set; }

        /// <summary>
        /// Community access settings
        /// </summary>
        [JsonProperty("access")]
        public int? Access { get; set; }

        /// <summary>
        /// Audio settings
        /// </summary>
        [JsonProperty("audio")]
        public int? Audio { get; set; }

        /// <summary>
        /// Video settings
        /// </summary>
        [JsonProperty("video")]
        public int? Video { get; set; }

        /// <summary>
        /// Community title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The list of stop words
        /// </summary>
        [JsonProperty("obscene_words")]
        public string ObsceneWords { get; set; }

        /// <summary>
        /// Wall settings
        /// </summary>
        [JsonProperty("wall")]
        public int? Wall { get; set; }

        /// <summary>
        /// Topics settings
        /// </summary>
        [JsonProperty("topics")]
        public int? Topics { get; set; }

        /// <summary>
        /// URL of the RSS feed
        /// </summary>
        [JsonProperty("rss")]
        public string Rss { get; set; }

        /// <summary>
        /// Community description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Photos settings
        /// </summary>
        [JsonProperty("photos")]
        public int? Photos { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("subject_list")]
        public IEnumerable<SubjectItem> SubjectList { get; set; }

        /// <summary>
        /// Information whether the obscene filter is enabled
        /// </summary>
        [JsonProperty("obscene_filter")]
        public int? ObsceneFilter { get; set; }

        /// <summary>
        /// Docs settings
        /// </summary>
        [JsonProperty("docs")]
        public int? Docs { get; set; }
    }
}