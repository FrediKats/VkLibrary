using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsCover
    {
        ///<summary>
        /// Information whether cover is enabled
        ///</summary>
        [JsonProperty("enabled")]
        public int Enabled { get; set; }
        [JsonProperty("images")]
        public BaseImage[] Images { get; set; }
    }
}