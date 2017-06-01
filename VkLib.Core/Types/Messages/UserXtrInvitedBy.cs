using Newtonsoft.Json;
using VkLib.Types.Users;

namespace VkLib.Types.Messages
{
    public class UserXtrInvitedBy : UserXtrType
    {
        /// <summary>
        ///     ID of the inviter
        /// </summary>
        [JsonProperty("invited_by")]
        public int? InvitedBy { get; set; }
    }
}