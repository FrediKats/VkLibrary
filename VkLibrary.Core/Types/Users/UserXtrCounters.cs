using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Users
{
    /// <summary>
    /// API UserXtrCounters object.
    /// </summary>
    public class UserXtrCounters : UserFull
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("counters")]
        public UserCounters Counters { get; set; }
    }
}