using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class PrettyCardsDeleteResponse
    {
        ///<summary>
        /// Owner ID of deleted pretty card
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// Card ID of deleted pretty card
        ///</summary>
        [JsonProperty("card_id")]
        public String CardId { get; set; }

        ///<summary>
        /// Error reason if error happened
        ///</summary>
        [JsonProperty("error")]
        public String Error { get; set; }
    }
}