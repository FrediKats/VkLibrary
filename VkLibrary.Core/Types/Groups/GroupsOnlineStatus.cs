using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
{
    ///<summary>
    /// Online status of group
    ///</summary>
    public class GroupsOnlineStatus
    {
        ///<summary>
        /// Estimated time of answer (for status = answer_mark)
        ///</summary>
        [JsonProperty("minutes")]
        public int Minutes { get; set; }
        [JsonProperty("status")]
        public GroupsOnlineStatusType Status { get; set; }
    }
}