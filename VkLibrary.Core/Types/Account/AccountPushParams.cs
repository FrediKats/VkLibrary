using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Account
{
    public class AccountPushParams
    {
        [JsonProperty("msg")]
        public AccountPushParamsMode[] Msg { get; set; }
        [JsonProperty("chat")]
        public AccountPushParamsMode[] Chat { get; set; }
        [JsonProperty("like")]
        public AccountPushParamsSettings[] Like { get; set; }
        [JsonProperty("repost")]
        public AccountPushParamsSettings[] Repost { get; set; }
        [JsonProperty("comment")]
        public AccountPushParamsSettings[] Comment { get; set; }
        [JsonProperty("mention")]
        public AccountPushParamsSettings[] Mention { get; set; }
        [JsonProperty("reply")]
        public AccountPushParamsOnoff[] Reply { get; set; }
        [JsonProperty("new_post")]
        public AccountPushParamsOnoff[] NewPost { get; set; }
        [JsonProperty("wall_post")]
        public AccountPushParamsOnoff[] WallPost { get; set; }
        [JsonProperty("wall_publish")]
        public AccountPushParamsOnoff[] WallPublish { get; set; }
        [JsonProperty("friend")]
        public AccountPushParamsOnoff[] Friend { get; set; }
        [JsonProperty("friend_found")]
        public AccountPushParamsOnoff[] FriendFound { get; set; }
        [JsonProperty("friend_accepted")]
        public AccountPushParamsOnoff[] FriendAccepted { get; set; }
        [JsonProperty("group_invite")]
        public AccountPushParamsOnoff[] GroupInvite { get; set; }
        [JsonProperty("group_accepted")]
        public AccountPushParamsOnoff[] GroupAccepted { get; set; }
        [JsonProperty("birthday")]
        public AccountPushParamsOnoff[] Birthday { get; set; }
        [JsonProperty("event_soon")]
        public AccountPushParamsOnoff[] EventSoon { get; set; }
        [JsonProperty("app_request")]
        public AccountPushParamsOnoff[] AppRequest { get; set; }
        [JsonProperty("sdk_open")]
        public AccountPushParamsOnoff[] SdkOpen { get; set; }
    }
}