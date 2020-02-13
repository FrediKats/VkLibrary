using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Account
{
    public class AccountPushConversations
    {
        ///<summary>
        /// Items count
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public AccountPushConversationsItem[] Items { get; set; }
    }
}