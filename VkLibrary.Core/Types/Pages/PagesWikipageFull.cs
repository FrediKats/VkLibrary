using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Pages
{
    public class PagesWikipageFull
    {
        ///<summary>
        /// Date when the page has been created in Unixtime
        ///</summary>
        [JsonProperty("created")]
        public int Created { get; set; }

        ///<summary>
        /// Page creator ID
        ///</summary>
        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        ///<summary>
        /// Information whether current user can edit the page
        ///</summary>
        [JsonProperty("current_user_can_edit")]
        public int CurrentUserCanEdit { get; set; }

        ///<summary>
        /// Information whether current user can edit the page access settings
        ///</summary>
        [JsonProperty("current_user_can_edit_access")]
        public int CurrentUserCanEditAccess { get; set; }

        ///<summary>
        /// Date when the page has been edited in Unixtime
        ///</summary>
        [JsonProperty("edited")]
        public int Edited { get; set; }

        ///<summary>
        /// Last editor ID
        ///</summary>
        [JsonProperty("editor_id")]
        public int EditorId { get; set; }

        ///<summary>
        /// Community ID
        ///</summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        ///<summary>
        /// Page content, HTML
        ///</summary>
        [JsonProperty("html")]
        public String Html { get; set; }

        ///<summary>
        /// Page ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Page content, wiki
        ///</summary>
        [JsonProperty("source")]
        public String Source { get; set; }

        ///<summary>
        /// Page title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// URL of the page preview
        ///</summary>
        [JsonProperty("view_url")]
        public String ViewUrl { get; set; }

        ///<summary>
        /// Views number
        ///</summary>
        [JsonProperty("views")]
        public int Views { get; set; }

        ///<summary>
        /// Edit settings of the page
        ///</summary>
        [JsonProperty("who_can_edit")]
        public PagesPrivacySettings WhoCanEdit { get; set; }

        ///<summary>
        /// View settings of the page
        ///</summary>
        [JsonProperty("who_can_view")]
        public PagesPrivacySettings WhoCanView { get; set; }
    }
}