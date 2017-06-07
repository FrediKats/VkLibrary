using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Groups
{
    /// <summary>
    /// API Group object.
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Level of current user's credentials as manager
        /// </summary>
        [JsonProperty("admin_level")]
        public int? AdminLevel { get; set; }

        /// <summary>
        /// URL of square photo of the community with 200 pixels in width
        /// </summary>
        [JsonProperty("photo_200")]
        public string Photo200 { get; set; }

        /// <summary>
        /// Information whether community is closed
        /// </summary>
        [JsonProperty("is_closed")]
        public int? IsClosed { get; set; }

        /// <summary>
        /// Community type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Community name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Domain of the community page
        /// </summary>
        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        /// <summary>
        /// Information whether current user is member
        /// </summary>
        [JsonProperty("is_member")]
        public int? IsMember { get; set; }

        /// <summary>
        /// Community ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// URL of square photo of the community with 50 pixels in width
        /// </summary>
        [JsonProperty("photo_50")]
        public string Photo50 { get; set; }

        /// <summary>
        /// Information whether current user is administrator
        /// </summary>
        [JsonProperty("is_admin")]
        public int? IsAdmin { get; set; }

        /// <summary>
        /// URL of square photo of the community with 100 pixels in width
        /// </summary>
        [JsonProperty("photo_100")]
        public string Photo100 { get; set; }
    }
}