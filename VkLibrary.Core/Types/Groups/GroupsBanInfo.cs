using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsBanInfo
    {
        ///<summary>
        /// Administrator ID
        ///</summary>
        [JsonProperty("admin_id")]
        public int AdminId { get; set; }

        ///<summary>
        /// Comment for a ban
        ///</summary>
        [JsonProperty("comment")]
        public String Comment { get; set; }

        ///<summary>
        /// Show comment for user
        ///</summary>
        [JsonProperty("comment_visible")]
        public Boolean CommentVisible { get; set; }
        [JsonProperty("is_closed")]
        public Boolean IsClosed { get; set; }

        ///<summary>
        /// Date when user has been added to blacklist in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Date when user will be removed from blacklist in Unixtime
        ///</summary>
        [JsonProperty("end_date")]
        public int EndDate { get; set; }
        [JsonProperty("reason")]
        public GroupsBanInfoReason Reason { get; set; }
    }
}