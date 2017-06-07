using Newtonsoft.Json;
using VkLibrary.Core.Types.Board;
using VkLibrary.Core.Types.Photos;
using VkLibrary.Core.Types.Wall;

namespace VkLibrary.Core.Types.Notifications
{
    /// <summary>
    /// API NotificationsComment object.
    /// </summary>
    public class NotificationsComment
    {
        /// <summary>
        /// Date when the comment has been added in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Comment ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Author ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("topic")]
        public Topic Topic { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo")]
        public Photo Photo { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("video")]
        public Video.Video Video { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("post")]
        public Wallpost Post { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}