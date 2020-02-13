using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackVideoComment
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("from_id")]
        public int FromId { get; set; }
        [JsonProperty("date")]
        public int Date { get; set; }
        [JsonProperty("text")]
        public String Text { get; set; }
        [JsonProperty("video_owner_od")]
        public int VideoOwnerOd { get; set; }
    }
}