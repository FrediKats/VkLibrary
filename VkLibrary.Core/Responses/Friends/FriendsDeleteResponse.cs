using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Responses.Friends
{
    public class FriendsDeleteResponse
    {
        [JsonProperty("success")]
        public BaseOkResponse Success { get; set; }

        ///<summary>
        /// Returns 1 if friend has been deleted
        ///</summary>
        [JsonProperty("friend_deleted")]
        public int FriendDeleted { get; set; }

        ///<summary>
        /// Returns 1 if out request has been canceled
        ///</summary>
        [JsonProperty("out_request_deleted")]
        public int OutRequestDeleted { get; set; }

        ///<summary>
        /// Returns 1 if incoming request has been declined
        ///</summary>
        [JsonProperty("in_request_deleted")]
        public int InRequestDeleted { get; set; }

        ///<summary>
        /// Returns 1 if suggestion has been declined
        ///</summary>
        [JsonProperty("suggestion_deleted")]
        public int SuggestionDeleted { get; set; }
    }
}