using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Messages
{
    public class MessagesDeleteConversationResponse
    {
        ///<summary>
        /// Id of the last message, that was deleted
        ///</summary>
        [JsonProperty("last_deleted_id")]
        public int LastDeletedId { get; set; }
    }
}