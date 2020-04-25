using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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