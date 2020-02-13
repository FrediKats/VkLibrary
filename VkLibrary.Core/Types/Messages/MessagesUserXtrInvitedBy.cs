using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Messages
{
    public class MessagesUserXtrInvitedBy
    {
        ///<summary>
        /// ID of the inviter
        ///</summary>
        [JsonProperty("invited_by")]
        public int InvitedBy { get; set; }
    }
}