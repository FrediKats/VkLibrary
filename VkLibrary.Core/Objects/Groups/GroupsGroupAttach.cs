using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GroupsGroupAttach
    {
        ///<summary>
        /// group ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// text of attach
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// activity or category of group
        ///</summary>
        [JsonProperty("status")]
        public String Status { get; set; }

        ///<summary>
        /// size of group
        ///</summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        ///<summary>
        /// is favorite
        ///</summary>
        [JsonProperty("is_favorite")]
        public Boolean IsFavorite { get; set; }
    }
}