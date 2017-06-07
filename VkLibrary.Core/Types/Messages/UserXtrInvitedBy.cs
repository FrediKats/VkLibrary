using Newtonsoft.Json;
using VkLibrary.Core.Types.Users;

namespace VkLibrary.Core.Types.Messages
{
    /// <summary>
    /// API UserXtrInvitedBy object.
    /// </summary>
    public class UserXtrInvitedBy : UserXtrType
    {
        /// <summary>
        /// ID of the inviter
        /// </summary>
        [JsonProperty("invited_by")]
        public int? InvitedBy { get; set; }
    }
}