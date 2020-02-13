using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Groups;

namespace VkApi.Wrapper.Types.Events
{
    public class EventsEventAttach
    {
        ///<summary>
        /// address of event
        ///</summary>
        [JsonProperty("address")]
        public String Address { get; set; }

        ///<summary>
        /// text of attach
        ///</summary>
        [JsonProperty("button_text")]
        public String ButtonText { get; set; }

        ///<summary>
        /// array of friends ids
        ///</summary>
        [JsonProperty("friends")]
        public int[] Friends { get; set; }

        ///<summary>
        /// event ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// is favorite
        ///</summary>
        [JsonProperty("is_favorite")]
        public Boolean IsFavorite { get; set; }

        ///<summary>
        /// Current user's member status
        ///</summary>
        [JsonProperty("member_status")]
        public GroupsGroupFullMemberStatus MemberStatus { get; set; }

        ///<summary>
        /// text of attach
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// event start time
        ///</summary>
        [JsonProperty("time")]
        public int Time { get; set; }
    }
}