using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Secure
{
    public class SecureLevel
    {
        ///<summary>
        /// Level
        ///</summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("uid")]
        public int Uid { get; set; }
    }
}