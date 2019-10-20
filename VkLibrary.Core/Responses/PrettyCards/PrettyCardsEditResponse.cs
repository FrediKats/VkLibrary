using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
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