using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.PrettyCards
{
    public class PrettyCardsEditResponse
    {
        ///<summary>
        /// Owner ID of edited pretty card
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// Card ID of edited pretty card
        ///</summary>
        [JsonProperty("card_id")]
        public String CardId { get; set; }
    }
}