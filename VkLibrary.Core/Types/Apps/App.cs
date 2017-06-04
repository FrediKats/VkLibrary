using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Photos;

namespace VkLibrary.Core.Types.Apps
{
    public class App
    {
        /// <summary>
        /// Information whether the application is multilanguage
        /// </summary>
        [JsonProperty("international")]
        public int? International { get; set; }

        /// <summary>
        /// Catalog position
        /// </summary>
        [JsonProperty("catalog_position")]
        public int? CatalogPosition { get; set; }

        /// <summary>
        /// URL of the app icon with 139 px in width
        /// </summary>
        [JsonProperty("icon_139")]
        public string Icon139 { get; set; }

        /// <summary>
        /// Application author's URL
        /// </summary>
        [JsonProperty("author_url")]
        public string AuthorUrl { get; set; }

        /// <summary>
        /// Application ID in store
        /// </summary>
        [JsonProperty("platform_id")]
        public int? PlatformId { get; set; }

        /// <summary>
        /// Information whther application is in mobile catalog
        /// </summary>
        [JsonProperty("is_in_catalog")]
        public int? IsInCatalog { get; set; }

        /// <summary>
        /// Genre ID
        /// </summary>
        [JsonProperty("genre_id")]
        public int? GenreId { get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Application section name
        /// </summary>
        [JsonProperty("section")]
        public string Section { get; set; }

        /// <summary>
        /// Genre name
        /// </summary>
        [JsonProperty("genre")]
        public string Genre { get; set; }

        /// <summary>
        /// URL of the app banner with 560 px in width
        /// </summary>
        [JsonProperty("banner_560")]
        public string Banner560 { get; set; }

        /// <summary>
        /// Leaderboard type
        /// </summary>
        [JsonProperty("leaderboard_type")]
        public int? LeaderboardType { get; set; }

        /// <summary>
        /// Members number
        /// </summary>
        [JsonProperty("members_count")]
        public int? MembersCount { get; set; }

        /// <summary>
        /// Screen name
        /// </summary>
        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        /// <summary>
        /// URL of the app icon with 279 px in width
        /// </summary>
        [JsonProperty("icon_278")]
        public string Icon278 { get; set; }

        /// <summary>
        /// Application title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// URL of the app icon with 150 px in width
        /// </summary>
        [JsonProperty("icon_150")]
        public string Icon150 { get; set; }

        /// <summary>
        /// URL of the app icon with 75 px in width
        /// </summary>
        [JsonProperty("icon_75")]
        public string Icon75 { get; set; }

        /// <summary>
        /// Application type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// URL of the app banner with 1120 px in width
        /// </summary>
        [JsonProperty("banner_1120")]
        public string Banner1120 { get; set; }

        /// <summary>
        /// Application description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Official community's ID
        /// </summary>
        [JsonProperty("author_group")]
        public int? AuthorGroup { get; set; }

        /// <summary>
        /// Application author's ID
        /// </summary>
        [JsonProperty("author_id")]
        public int? AuthorId { get; set; }

        /// <summary>
        /// Date when the application has been published in Unixtime
        /// </summary>
        [JsonProperty("published_date")]
        public int? PublishedDate { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("screenshots")]
        public IEnumerable<Photo> Screenshots { get; set; }
    }
}