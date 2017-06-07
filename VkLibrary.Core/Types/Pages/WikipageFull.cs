using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Pages
{
    /// <summary>
    /// API WikipageFull object.
    /// </summary>
    public class WikipageFull
    {
        /// <summary>
        /// Last editor ID
        /// </summary>
        [JsonProperty("editor_id")]
        public int? EditorId { get; set; }

        /// <summary>
        /// Community ID
        /// </summary>
        [JsonProperty("group_id")]
        public int? GroupId { get; set; }

        /// <summary>
        /// Page ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Date when the page has been edited in Unixtime
        /// </summary>
        [JsonProperty("edited")]
        public int? Edited { get; set; }

        /// <summary>
        /// Edit settings of the page
        /// </summary>
        [JsonProperty("who_can_edit")]
        public string WhoCanEdit { get; set; }

        /// <summary>
        /// Page content, wiki
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// View settings of the page
        /// </summary>
        [JsonProperty("who_can_view")]
        public string WhoCanView { get; set; }

        /// <summary>
        /// Information whether current user can edit the page
        /// </summary>
        [JsonProperty("current_user_can_edit")]
        public int? CurrentUserCanEdit { get; set; }

        /// <summary>
        /// Page title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// URL of the page preview
        /// </summary>
        [JsonProperty("view_url")]
        public string ViewUrl { get; set; }

        /// <summary>
        /// Information whether current user can edit the page access settings
        /// </summary>
        [JsonProperty("current_user_can_edit_access")]
        public int? CurrentUserCanEditAccess { get; set; }

        /// <summary>
        /// Views number
        /// </summary>
        [JsonProperty("views")]
        public int? Views { get; set; }

        /// <summary>
        /// Page creator ID
        /// </summary>
        [JsonProperty("creator_id")]
        public int? CreatorId { get; set; }

        /// <summary>
        /// Page content, HTML
        /// </summary>
        [JsonProperty("html")]
        public string Html { get; set; }

        /// <summary>
        /// Date when the page has been created in Unixtime
        /// </summary>
        [JsonProperty("created")]
        public int? Created { get; set; }
    }
}