using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GroupsGroupXtrInvitedBy
    {
        [JsonProperty("admin_level")]
        public GroupsGroupXtrInvitedByAdminLevel AdminLevel { get; set; }

        ///<summary>
        /// Community ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Inviter ID
        ///</summary>
        [JsonProperty("invited_by")]
        public int InvitedBy { get; set; }

        ///<summary>
        /// Information whether current user is manager
        ///</summary>
        [JsonProperty("is_admin")]
        public int IsAdmin { get; set; }

        ///<summary>
        /// Information whether current user is advertiser
        ///</summary>
        [JsonProperty("is_advertiser")]
        public int IsAdvertiser { get; set; }

        ///<summary>
        /// Information whether community is closed
        ///</summary>
        [JsonProperty("is_closed")]
        public int IsClosed { get; set; }

        ///<summary>
        /// Information whether current user is member
        ///</summary>
        [JsonProperty("is_member")]
        public int IsMember { get; set; }

        ///<summary>
        /// Community name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// URL of square photo of the community with 100 pixels in width
        ///</summary>
        [JsonProperty("photo_100")]
        public String Photo100 { get; set; }

        ///<summary>
        /// URL of square photo of the community with 200 pixels in width
        ///</summary>
        [JsonProperty("photo_200")]
        public String Photo200 { get; set; }

        ///<summary>
        /// URL of square photo of the community with 50 pixels in width
        ///</summary>
        [JsonProperty("photo_50")]
        public String Photo50 { get; set; }

        ///<summary>
        /// Domain of the community page
        ///</summary>
        [JsonProperty("screen_name")]
        public String ScreenName { get; set; }
        [JsonProperty("type")]
        public GroupsGroupXtrInvitedByType Type { get; set; }
    }
}