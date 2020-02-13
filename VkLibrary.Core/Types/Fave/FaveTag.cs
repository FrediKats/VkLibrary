using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Fave
{
    public class FaveTag
    {
        ///<summary>
        /// Tag id
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Tag name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}