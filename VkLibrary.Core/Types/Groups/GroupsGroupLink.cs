using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsGroupLink
    {
        ///<summary>
        /// Link label
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// Link description
        ///</summary>
        [JsonProperty("desc")]
        public String Desc { get; set; }

        ///<summary>
        /// Information whether the title can be edited
        ///</summary>
        [JsonProperty("edit_title")]
        public int EditTitle { get; set; }

        ///<summary>
        /// Link ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Information whether the image on processing
        ///</summary>
        [JsonProperty("image_processing")]
        public int ImageProcessing { get; set; }

        ///<summary>
        /// Link URL
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}