using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Pages
{
    public class Wikipage
    {
        /// <summary>
        /// Views number
        /// </summary>
        [JsonProperty("views")]
        public int? Views { get; set; }

        /// <summary>
        /// Last editor name
        /// </summary>
        [JsonProperty("editor_name")]
        public string EditorName { get; set; }

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
        /// Edit settings of the page
        /// </summary>
        [JsonProperty("who_can_edit")]
        public string WhoCanEdit { get; set; }

        /// <summary>
        /// View settings of the page
        /// </summary>
        [JsonProperty("who_can_view")]
        public string WhoCanView { get; set; }

        /// <summary>
        /// Page creator name
        /// </summary>
        [JsonProperty("creator_name")]
        public int? CreatorName { get; set; }

        /// <summary>
        /// Page title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Page creator ID
        /// </summary>
        [JsonProperty("creator_id")]
        public int? CreatorId { get; set; }
    }
}