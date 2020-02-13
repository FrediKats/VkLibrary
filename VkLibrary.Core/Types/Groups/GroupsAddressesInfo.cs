using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsAddressesInfo
    {
        ///<summary>
        /// Information whether addresses is enabled
        ///</summary>
        [JsonProperty("is_enabled")]
        public Boolean IsEnabled { get; set; }

        ///<summary>
        /// Main address id for group
        ///</summary>
        [JsonProperty("main_address_id")]
        public int MainAddressId { get; set; }
    }
}