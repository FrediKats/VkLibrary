using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Apps
{
    ///<summary>
    /// Scope description
    ///</summary>
    public class AppsScope
    {
        ///<summary>
        /// Scope name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// Scope title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}