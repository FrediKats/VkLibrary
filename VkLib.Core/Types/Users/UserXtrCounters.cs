using Newtonsoft.Json;

namespace VkLib.Types.Users
{
    public class UserXtrCounters : UserFull
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("counters")]
        public UserCounters Counters { get; set; }
    }
}