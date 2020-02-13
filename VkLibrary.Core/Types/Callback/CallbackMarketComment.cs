using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackMarketComment
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("from_id")]
        public int FromId { get; set; }
        [JsonProperty("date")]
        public int Date { get; set; }
        [JsonProperty("text")]
        public String Text { get; set; }
        [JsonProperty("market_owner_od")]
        public int MarketOwnerOd { get; set; }
        [JsonProperty("photo_id")]
        public int PhotoId { get; set; }
    }
}