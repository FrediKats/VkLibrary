using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AppsApp : AppsAppMin
    {
        ///<summary>
        /// Application author's URL
        ///</summary>
        [JsonProperty("author_url")]
        public String AuthorUrl { get; set; }

        ///<summary>
        /// URL of the app banner with 1120 px in width
        ///</summary>
        [JsonProperty("banner_1120")]
        public String Banner1120 { get; set; }

        ///<summary>
        /// URL of the app banner with 560 px in width
        ///</summary>
        [JsonProperty("banner_560")]
        public String Banner560 { get; set; }

        ///<summary>
        /// URL of the app icon with 16 px in width
        ///</summary>
        [JsonProperty("icon_16")]
        public String Icon16 { get; set; }

        ///<summary>
        /// Is new flag
        ///</summary>
        [JsonProperty("is_new")]
        public int IsNew { get; set; }

        ///<summary>
        /// Is push enabled
        ///</summary>
        [JsonProperty("push_enabled")]
        public int PushEnabled { get; set; }

        ///<summary>
        /// Screen orientation
        ///</summary>
        [JsonProperty("screen_orientation")]
        public int ScreenOrientation { get; set; }
        [JsonProperty("friends")]
        public int[] Friends { get; set; }

        ///<summary>
        /// Catalog position
        ///</summary>
        [JsonProperty("catalog_position")]
        public int CatalogPosition { get; set; }

        ///<summary>
        /// Application description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// Genre name
        ///</summary>
        [JsonProperty("genre")]
        public String Genre { get; set; }

        ///<summary>
        /// Genre ID
        ///</summary>
        [JsonProperty("genre_id")]
        public int GenreId { get; set; }

        ///<summary>
        /// Information whether the application is multilanguage
        ///</summary>
        [JsonProperty("international")]
        public Boolean International { get; set; }

        ///<summary>
        /// Information whether application is in mobile catalog
        ///</summary>
        [JsonProperty("is_in_catalog")]
        public int IsInCatalog { get; set; }
        [JsonProperty("leaderboard_type")]
        public AppsAppLeaderboardType LeaderboardType { get; set; }

        ///<summary>
        /// Members number
        ///</summary>
        [JsonProperty("members_count")]
        public int MembersCount { get; set; }

        ///<summary>
        /// Application ID in store
        ///</summary>
        [JsonProperty("platform_id")]
        public String PlatformId { get; set; }

        ///<summary>
        /// Date when the application has been published in Unixtime
        ///</summary>
        [JsonProperty("published_date")]
        public int PublishedDate { get; set; }

        ///<summary>
        /// Screen name
        ///</summary>
        [JsonProperty("screen_name")]
        public String ScreenName { get; set; }

        ///<summary>
        /// Application section name
        ///</summary>
        [JsonProperty("section")]
        public String Section { get; set; }
    }
}