using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class NewsfeedGetRecommendedResponse
    {
        [JsonProperty("items")]
        public NewsfeedNewsfeedItem[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroupFull[] Groups { get; set; }

        ///<summary>
        /// New offset value
        ///</summary>
        [JsonProperty("new_offset")]
        public String NewOffset { get; set; }

        ///<summary>
        /// Next from value
        ///</summary>
        [JsonProperty("next_from")]
        public String NextFrom { get; set; }
    }
}