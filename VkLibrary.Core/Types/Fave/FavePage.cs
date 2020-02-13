using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;
using VkApi.Wrapper.Types.Users;

namespace VkApi.Wrapper.Types.Fave
{
    public class FavePage
    {
        ///<summary>
        /// Some info about user or group
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }
        [JsonProperty("group")]
        public GroupsGroupFull Group { get; set; }
        [JsonProperty("tags")]
        public FaveTag[] Tags { get; set; }

        ///<summary>
        /// Item type
        ///</summary>
        [JsonProperty("type")]
        public FavePageType Type { get; set; }

        ///<summary>
        /// Timestamp, when this page was bookmarked
        ///</summary>
        [JsonProperty("updated_date")]
        public int UpdatedDate { get; set; }
        [JsonProperty("user")]
        public UsersUserFull User { get; set; }
    }
}