using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    public class GroupsMemberStatus
    {
        ///<summary>
        /// Information whether user is a member of the group
        ///</summary>
        [JsonProperty("member")]
        public int Member { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}