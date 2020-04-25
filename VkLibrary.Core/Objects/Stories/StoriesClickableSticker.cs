using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class StoriesClickableSticker
    {
        //TODO: fix
        //[JsonProperty("clickable_area")]
        //public StoriesClickableArea[] ClickableArea { get; set; }

        ///<summary>
        /// Clickable sticker ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("hashtag")]
        public String Hashtag { get; set; }
        [JsonProperty("link_object")]
        public BaseLink LinkObject { get; set; }
        [JsonProperty("mention")]
        public String Mention { get; set; }
        [JsonProperty("tooltip_text")]
        public String TooltipText { get; set; }
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("story_id")]
        public int StoryId { get; set; }
        [JsonProperty("question")]
        public String Question { get; set; }
        [JsonProperty("question_button")]
        public String QuestionButton { get; set; }
        [JsonProperty("place_id")]
        public int PlaceId { get; set; }
        [JsonProperty("market_item")]
        public MarketMarketItem MarketItem { get; set; }
        [JsonProperty("audio")]
        public AudioAudio Audio { get; set; }
        [JsonProperty("audio_start_time")]
        public int AudioStartTime { get; set; }
        [JsonProperty("style")]
        public String Style { get; set; }
        [JsonProperty("type")]
        public String Type { get; set; }
        [JsonProperty("subtype")]
        public String Subtype { get; set; }
        [JsonProperty("post_owner_id")]
        public int PostOwnerId { get; set; }
        [JsonProperty("post_id")]
        public int PostId { get; set; }
        [JsonProperty("poll")]
        public PollsPoll Poll { get; set; }

        ///<summary>
        /// Color, hex format
        ///</summary>
        [JsonProperty("color")]
        public String Color { get; set; }

        ///<summary>
        /// Sticker ID
        ///</summary>
        [JsonProperty("sticker_id")]
        public int StickerId { get; set; }

        ///<summary>
        /// Sticker pack ID
        ///</summary>
        [JsonProperty("sticker_pack_id")]
        public int StickerPackId { get; set; }
        [JsonProperty("app")]
        public AppsAppMin App { get; set; }

        ///<summary>
        /// Additional context for app sticker
        ///</summary>
        [JsonProperty("app_context")]
        public String AppContext { get; set; }

        ///<summary>
        /// Whether current user has unread interaction with this app
        ///</summary>
        [JsonProperty("has_new_interactions")]
        public Boolean HasNewInteractions { get; set; }

        ///<summary>
        /// Whether current user allowed broadcast notify from this app
        ///</summary>
        [JsonProperty("is_broadcast_notify_allowed")]
        public Boolean IsBroadcastNotifyAllowed { get; set; }
    }
}