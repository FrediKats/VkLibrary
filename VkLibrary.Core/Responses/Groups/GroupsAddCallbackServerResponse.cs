using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Groups
{
    public class GroupsAddCallbackServerResponse
    {
        [JsonProperty("server_id")]
        public int ServerId { get; set; }
    }
}