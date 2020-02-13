using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Messages
{
    public class MessagesLastActivity
    {
        ///<summary>
        /// Information whether user is online
        ///</summary>
        [JsonProperty("online")]
        public int Online { get; set; }

        ///<summary>
        /// Time when user was online in Unixtime
        ///</summary>
        [JsonProperty("time")]
        public int Time { get; set; }
    }
}