using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Stats
{
    ///<summary>
    /// Activity stats
    ///</summary>
    public class StatsActivity
    {
        ///<summary>
        /// Comments number
        ///</summary>
        [JsonProperty("comments")]
        public int Comments { get; set; }

        ///<summary>
        /// Reposts number
        ///</summary>
        [JsonProperty("copies")]
        public int Copies { get; set; }

        ///<summary>
        /// Hidden from news count
        ///</summary>
        [JsonProperty("hidden")]
        public int Hidden { get; set; }

        ///<summary>
        /// Likes number
        ///</summary>
        [JsonProperty("likes")]
        public int Likes { get; set; }

        ///<summary>
        /// New subscribers count
        ///</summary>
        [JsonProperty("subscribed")]
        public int Subscribed { get; set; }

        ///<summary>
        /// Unsubscribed count
        ///</summary>
        [JsonProperty("unsubscribed")]
        public int Unsubscribed { get; set; }
    }
}